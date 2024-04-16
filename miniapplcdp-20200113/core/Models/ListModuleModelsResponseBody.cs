// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListModuleModelsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListModuleModelsResponseBodyData Data { get; set; }
        public class ListModuleModelsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListModuleModelsResponseBodyDataItems> Items { get; set; }
            public class ListModuleModelsResponseBodyDataItems : TeaModel {
                [NameInMap("CommitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("ModelData")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataItemsModelDataValue>> ModelData { get; set; }

                [NameInMap("ModelDataPath")]
                [Validation(Required=false)]
                public Dictionary<string, string> ModelDataPath { get; set; }

                [NameInMap("ModelDigest")]
                [Validation(Required=false)]
                public Dictionary<string, string> ModelDigest { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("ResourceData")]
                [Validation(Required=false)]
                public Dictionary<string, string> ResourceData { get; set; }

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
