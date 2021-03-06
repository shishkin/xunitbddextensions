﻿// Copyright 2009 Björn Rochel - http://www.bjro.de/ 
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
using Rhino.Mocks.Interfaces;

namespace Xunit
{
    public static class EventRaiserExtensions
    {
        public static IEventRaiser Event<T>(this T dependency, Action<T> eventSubscription) where T : class
        {
            return dependency.Stub(eventSubscription).IgnoreArguments().GetEventRaiser();
        }
    }
}
