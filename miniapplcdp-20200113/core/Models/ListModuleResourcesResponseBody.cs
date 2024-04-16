// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListModuleResourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListModuleResourcesResponseBodyData Data { get; set; }
        public class ListModuleResourcesResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListModuleResourcesResponseBodyDataItems> Items { get; set; }
            public class ListModuleResourcesResponseBodyDataItems : TeaModel {
                [NameInMap("CommitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("ModelData")]
                [Validation(Required=false)]
                public Dictionary<string, string> ModelData { get; set; }

                [NameInMap("ModelDataPath")]
                [Validation(Required=false)]
                public Dictionary<string, string> ModelDataPath { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("ResourceData")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataItemsResourceDataValue>> ResourceData { get; set; }

                [NameInMap("ResourceDataPath")]
                [Validation(Required=false)]
                public Dictionary<string, string> ResourceDataPath { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
