// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvDetailModel : TeaModel {
        [NameInMap("BaseTableInfos")]
        [Validation(Required=false)]
        public List<OpenStructMvDetailModelBaseTableInfos> BaseTableInfos { get; set; }
        public class OpenStructMvDetailModelBaseTableInfos : TeaModel {
            [NameInMap("BaseTableIsMv")]
            [Validation(Required=false)]
            public bool? BaseTableIsMv { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        [NameInMap("BaseTableNames")]
        [Validation(Required=false)]
        public List<List<string>> BaseTableNames { get; set; }

        [NameInMap("ExplicitHit")]
        [Validation(Required=false)]
        public long? ExplicitHit { get; set; }

        [NameInMap("FirstRefreshTime")]
        [Validation(Required=false)]
        public string FirstRefreshTime { get; set; }

        [NameInMap("ImplicitHit")]
        [Validation(Required=false)]
        public long? ImplicitHit { get; set; }

        [NameInMap("IsInactive")]
        [Validation(Required=false)]
        public bool? IsInactive { get; set; }

        [NameInMap("LocalSize")]
        [Validation(Required=false)]
        public long? LocalSize { get; set; }

        [NameInMap("QueryRewriteEnabled")]
        [Validation(Required=false)]
        public bool? QueryRewriteEnabled { get; set; }

        [NameInMap("RefreshInterval")]
        [Validation(Required=false)]
        public string RefreshInterval { get; set; }

        [NameInMap("RefreshState")]
        [Validation(Required=false)]
        public string RefreshState { get; set; }

        [NameInMap("RemoteSize")]
        [Validation(Required=false)]
        public long? RemoteSize { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
