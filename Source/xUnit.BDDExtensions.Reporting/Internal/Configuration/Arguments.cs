// Copyright 2008 Bj�rn Rochel - http://www.bjro.de/ 
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit.Internal;

namespace Xunit.Reporting.Internal.Configuration
{
    /// <summary>
    /// A collection for property values. This abstraction serves together with <see cref="ArgumentKey{TValue}"/> as a 
    /// simple strong typed property bag.
    /// </summary>
    public class Arguments : IArguments
    {
        private readonly IArgumentMap _argumentMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="Arguments"/> class.
        /// </summary>
        /// <param name="argumentMap">The dictionary.</param>
        public Arguments(IArgumentMap argumentMap)
        {
            Guard.AgainstArgumentNull(argumentMap, "argumentMap");

            _argumentMap = argumentMap;
        }

        #region Implementation of IArguments

        /// <summary>
        /// Gets the value for the property key specified by <paramref name="key"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Specifies the type of the concrete value.
        /// </typeparam>
        /// <param name="key">
        /// Specifies the key for the value in the bag.
        /// </param>
        /// <returns>
        /// The found value or the default value for <typeparamref name="TValue"/> when
        /// no value was specified.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="key"/> is <c>null</c>.
        /// </exception>
        public TValue Get<TValue>(ArgumentKey<TValue> key)
        {
            Guard.AgainstArgumentNull(key, "key");

            return key.ParseValue(_argumentMap);
        }

        #endregion
    }
}