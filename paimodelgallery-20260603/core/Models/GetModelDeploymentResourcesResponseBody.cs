// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class GetModelDeploymentResourcesResponseBody : TeaModel {
        [NameInMap("MemberMatches")]
        [Validation(Required=false)]
        public List<GetModelDeploymentResourcesResponseBodyMemberMatches> MemberMatches { get; set; }
        public class GetModelDeploymentResourcesResponseBodyMemberMatches : TeaModel {
            [NameInMap("DedicatedResources")]
            [Validation(Required=false)]
            public List<GetModelDeploymentResourcesResponseBodyMemberMatchesDedicatedResources> DedicatedResources { get; set; }
            public class GetModelDeploymentResourcesResponseBodyMemberMatchesDedicatedResources : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eas-r-lq9p****ao9m2</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("PublicResources")]
            [Validation(Required=false)]
            public List<GetModelDeploymentResourcesResponseBodyMemberMatchesPublicResources> PublicResources { get; set; }
            public class GetModelDeploymentResourcesResponseBodyMemberMatchesPublicResources : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ml.gx9cf.8.62xlarg</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<GetModelDeploymentResourcesResponseBodyMemberMatchesQuotas> Quotas { get; set; }
            public class GetModelDeploymentResourcesResponseBodyMemberMatchesQuotas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>quotagn***bb68</para>
                /// </summary>
                [NameInMap("QuotaId")]
                [Validation(Required=false)]
                public string QuotaId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6B54325-C98C-5937-87A3-2F96C07652EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
