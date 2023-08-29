// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMgsApipageRequest : TeaModel {
        [NameInMap("ApiStatus")]
        [Validation(Required=false)]
        public string ApiStatus { get; set; }

        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("NeedEncrypt")]
        [Validation(Required=false)]
        public string NeedEncrypt { get; set; }

        [NameInMap("NeedEtag")]
        [Validation(Required=false)]
        public string NeedEtag { get; set; }

        [NameInMap("NeedSign")]
        [Validation(Required=false)]
        public string NeedSign { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OptFuzzy")]
        [Validation(Required=false)]
        public string OptFuzzy { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SysId")]
        [Validation(Required=false)]
        public long? SysId { get; set; }

        [NameInMap("SysName")]
        [Validation(Required=false)]
        public string SysName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
