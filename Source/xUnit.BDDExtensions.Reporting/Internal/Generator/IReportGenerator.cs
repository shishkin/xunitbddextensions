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
namespace Xunit.Reporting.Internal.Generator
{
    /// <summary>
    /// A report generator.
    /// </summary>
    public interface IReportGenerator
    {
        /// <summary>
        /// Generates a report filled with the content supplied by <paramref name="report"/>.
        /// </summary>
        /// <param name="report">
        /// Specifies the report model.
        /// </param>
        void Generate(IReport report);
    }
}