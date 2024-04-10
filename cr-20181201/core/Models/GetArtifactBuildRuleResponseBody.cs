// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildRuleResponseBody : TeaModel {
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public GetArtifactBuildRuleResponseBodyParameters Parameters { get; set; }
        public class GetArtifactBuildRuleResponseBodyParameters : TeaModel {
            [NameInMap("ImageIndexOnly")]
            [Validation(Required=false)]
            public bool? ImageIndexOnly { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
