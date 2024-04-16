// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class RestoreModelResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RestoreModelResponseBodyData Data { get; set; }
        public class RestoreModelResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Attributes { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public Dictionary<string, string> Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LinkModelId")]
            [Validation(Required=false)]
            public string LinkModelId { get; set; }

            [NameInMap("LinkModuleId")]
            [Validation(Required=false)]
            public string LinkModuleId { get; set; }

            [NameInMap("Linked")]
            [Validation(Required=false)]
            public bool? Linked { get; set; }

            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("ModelStatus")]
            [Validation(Required=false)]
            public string ModelStatus { get; set; }

            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("Props")]
            [Validation(Required=false)]
            public Dictionary<string, string> Props { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public int? Revision { get; set; }

            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public string SchemaVersion { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
