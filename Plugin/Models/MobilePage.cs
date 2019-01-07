﻿// <copyright>
// Copyright Southeast Christian Church
//
// Licensed under the  Southeast Christian Church License (the "License");
// you may not use this file except in compliance with the License.
// A copy of the License shoud be included with this file.
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalanche.Models
{
    public class MobilePage
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public bool ShowTitle { get; set; }
        public int CacheDuration { get; set; }
        public string Layout { get; set; }
        public List<MobileBlock> Blocks { get; set; }
        public Dictionary<string,string> Attributes { get; set; }
        public MobilePage()
        {
            Blocks = new List<MobileBlock>();
            Attributes = new Dictionary<string, string>();
        }
    }
}
