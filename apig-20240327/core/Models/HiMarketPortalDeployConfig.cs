// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalDeployConfig : TeaModel {
        /// <summary>
        /// <para>The deployment status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The deployment platform type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAE</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The SAE (Serverless App Engine) deployment configuration.</para>
        /// </summary>
        [NameInMap("saeConfig")]
        [Validation(Required=false)]
        public HiMarketPortalDeployConfigSaeConfig SaeConfig { get; set; }
        public class HiMarketPortalDeployConfigSaeConfig : TeaModel {
            /// <summary>
            /// <para>The SAE application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-xxx</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The SAE namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou:default</para>
            /// </summary>
            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The OIDC role name used for SAE to access other cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apig-portal-oidc-role</para>
            /// </summary>
            [NameInMap("oidcRoleName")]
            [Validation(Required=false)]
            public string OidcRoleName { get; set; }

            /// <summary>
            /// <para>The region ID of SAE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of instance replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The deployment status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
