// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetCommitResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommitResponseBodyData Data { get; set; }
        public class GetCommitResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CommitDigest")]
            [Validation(Required=false)]
            public string CommitDigest { get; set; }

            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            [NameInMap("CommitLog")]
            [Validation(Required=false)]
            public string CommitLog { get; set; }

            [NameInMap("CommitType")]
            [Validation(Required=false)]
            public string CommitType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("MainModuleCommitId")]
            [Validation(Required=false)]
            public string MainModuleCommitId { get; set; }

            [NameInMap("MainModuleId")]
            [Validation(Required=false)]
            public string MainModuleId { get; set; }

            [NameInMap("ModelDataPath")]
            [Validation(Required=false)]
            public string ModelDataPath { get; set; }

            [NameInMap("ModelDigest")]
            [Validation(Required=false)]
            public Dictionary<string, string> ModelDigest { get; set; }

            [NameInMap("ModelPack")]
            [Validation(Required=false)]
            public List<object> ModelPack { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("ResourceDataPath")]
            [Validation(Required=false)]
            public string ResourceDataPath { get; set; }

            [NameInMap("ResourceDigest")]
            [Validation(Required=false)]
            public Dictionary<string, string> ResourceDigest { get; set; }

            [NameInMap("ResourcePack")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> ResourcePack { get; set; }

            [NameInMap("RollbackToCommitId")]
            [Validation(Required=false)]
            public string RollbackToCommitId { get; set; }

            [NameInMap("RollbackType")]
            [Validation(Required=false)]
            public string RollbackType { get; set; }

            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public string SchemaVersion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
