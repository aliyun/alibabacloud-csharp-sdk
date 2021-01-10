// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricCloudmsgbinginginfoRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DevStage")]
        [Validation(Required=false)]
        public string DevStage { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("EnvListRepeatList")]
        [Validation(Required=false)]
        public List<string> EnvListRepeatList { get; set; }

        [NameInMap("EventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("OriginAppName")]
        [Validation(Required=false)]
        public string OriginAppName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
