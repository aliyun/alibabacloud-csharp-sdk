// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalDeployConfig : TeaModel {
        /// <summary>
        /// <para>Additional information about the deployment status, such as error details.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The target deployment platform. For example, set this to <c>SAE</c> to deploy on Serverless App Engine.</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>Configuration settings for deploying to Serverless App Engine (SAE). This object is required when the <c>platform</c> is <c>SAE</c>.</para>
        /// </summary>
        [NameInMap("saeConfig")]
        [Validation(Required=false)]
        public HiMarketPortalDeployConfigSaeConfig SaeConfig { get; set; }
        public class HiMarketPortalDeployConfigSaeConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the application in Serverless App Engine.</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the namespace that logically isolates the application.</para>
            /// </summary>
            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The name of the OIDC role that grants permissions to the application.</para>
            /// </summary>
            [NameInMap("oidcRoleName")]
            [Validation(Required=false)]
            public string OidcRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the region in which to deploy the application.</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The desired number of application replicas.</para>
            /// </summary>
            [NameInMap("replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            /// <summary>
            /// <para>The ID of the security group to apply to the application instances. A security group acts as a virtual firewall.</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch within the specified VPC. Serverless App Engine launches application instances in the vSwitch\&quot;s zone.</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to connect the application to.</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The current status of the deployment. Possible values include <c>succeeded</c>, <c>failed</c>, and <c>in_progress</c>.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
