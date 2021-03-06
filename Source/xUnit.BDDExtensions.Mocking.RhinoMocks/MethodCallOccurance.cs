// Copyright 2009 Bj�rn Rochel - http://www.bjro.de/ 
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System;
using Rhino.Mocks;

namespace Xunit
{
    /// <summary>
    /// This class encapsulates the Rhino.Mocks mechanics for specifiing call expectations.
    /// </summary>
    /// <typeparam name="TDependency">
    /// Specifies the type of the dependency which is configured via the methods on <see cref="RhinoMocksExtensions"/>.
    /// </typeparam>
    public class MethodCallOccurance<TDependency>
    {
        private readonly TDependency _dependency;
        private readonly Action<TDependency> _action;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodCallOccurance&lt;TDependency&gt;"/> class.
        /// </summary>
        /// <param name="mock">The dependency on which an action is expected.</param>
        /// <param name="action">The action that should have been called.</param>
        public MethodCallOccurance(TDependency mock, Action<TDependency> action)
        {
            _dependency = mock;
            _action = action;
            _dependency.AssertWasCalled(action, y => y.Repeat.AtLeastOnce());
        }

        /// <summary>
        /// Specifies that the action on the dependency should be called several times. <paramref name="numberOfTimesTheMethodShouldHaveBeenCalled"/>
        /// specifies exactly how often.
        /// </summary>
        /// <param name="numberOfTimesTheMethodShouldHaveBeenCalled">
        /// The number of times the method should have been called.
        /// </param>
        public void Times(int numberOfTimesTheMethodShouldHaveBeenCalled)
        {
            _dependency.AssertWasCalled(_action, y => y.Repeat.Times(numberOfTimesTheMethodShouldHaveBeenCalled));
        }

        /// <summary>
        /// Specifies that the action on the dependency should only be called once.
        /// </summary>
        public void OnlyOnce()
        {
            Times(1);
        }

        /// <summary>
        /// Specifies that the action on the dependency should be called twice.
        /// </summary>
        public void Twice()
        {
            Times(2);
        }
    }
}