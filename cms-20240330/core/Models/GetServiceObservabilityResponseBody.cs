// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceObservabilityResponseBody : TeaModel {
        [NameInMap("entryPointInfo")]
        [Validation(Required=false)]
        public GetServiceObservabilityResponseBodyEntryPointInfo EntryPointInfo { get; set; }
        public class GetServiceObservabilityResponseBodyEntryPointInfo : TeaModel {
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("privateDomain")]
            [Validation(Required=false)]
            public string PrivateDomain { get; set; }

            /// <summary>
            /// <para>SLS Project</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-xtrace-xxxxx</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

        }

        [NameInMap("feeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, string> Quotas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4852B9B5-345C-5CBC-A15F-786D83ECCBBA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
