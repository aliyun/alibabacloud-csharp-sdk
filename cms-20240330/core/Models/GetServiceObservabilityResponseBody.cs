// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceObservabilityResponseBody : TeaModel {
        /// <summary>
        /// <para>Endpoint and Authentication Information</para>
        /// </summary>
        [NameInMap("entryPointInfo")]
        [Validation(Required=false)]
        public GetServiceObservabilityResponseBodyEntryPointInfo EntryPointInfo { get; set; }
        public class GetServiceObservabilityResponseBodyEntryPointInfo : TeaModel {
            /// <summary>
            /// <para>Authentication Token for Data Reporting</para>
            /// 
            /// <b>Example:</b>
            /// <para>gaddp****@de20f2<em><b>1ce</b></em></para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>Private Network Access Address</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-xtrace-xxxx-cn-hangzhou.cn-hangzhou-intranet.log.aliyuncs.com</para>
            /// </summary>
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

            /// <summary>
            /// <para>Public Network Access Address</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-xtrace-xxxx-cn-hangzhou.cn-hangzhou.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

        }

        /// <summary>
        /// <para>Billing Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms=serverless;xtrace=serverless</para>
        /// </summary>
        [NameInMap("feeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        /// <summary>
        /// <para>Quota Configuration</para>
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, string> Quotas { get; set; }

        /// <summary>
        /// <para>Region</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4852B9B5-345C-5CBC-A15F-786D83ECCBBA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>System Configuration</para>
        /// </summary>
        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// <para>Resource Initialization Status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Application Observability Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Workspace Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1654218***343050-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
