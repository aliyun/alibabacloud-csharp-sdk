// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceObservabilityResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint and authentication information.</para>
        /// </summary>
        [NameInMap("entryPointInfo")]
        [Validation(Required=false)]
        public GetServiceObservabilityResponseBodyEntryPointInfo EntryPointInfo { get; set; }
        public class GetServiceObservabilityResponseBodyEntryPointInfo : TeaModel {
            /// <summary>
            /// <para>The authentication token for reporting data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gaddp****@de20f2<em><b>1ce</b></em></para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The internal endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-xtrace-xxxx-cn-hangzhou.cn-hangzhou-intranet.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("privateDomain")]
            [Validation(Required=false)]
            public string PrivateDomain { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-xtrace-xxxxx</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-xtrace-xxxx-cn-hangzhou.cn-hangzhou.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

        }

        /// <summary>
        /// <para>The billing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms=serverless;xtrace=serverless</para>
        /// </summary>
        [NameInMap("feeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        /// <summary>
        /// <para>The quota configuration.</para>
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, string> Quotas { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4852B9B5-345C-5CBC-A15F-786D83ECCBBA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The system configuration.</para>
        /// </summary>
        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// <para>The resource initialization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of application observability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1654218***343050-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
