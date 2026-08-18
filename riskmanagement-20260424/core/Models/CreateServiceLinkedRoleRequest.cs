// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleRequestSdkRequest SdkRequest { get; set; }
        public class CreateServiceLinkedRoleRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The service-linked role. Default value: <b>AliyunServiceRoleForSas</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AliyunServiceRoleForSas</b>: the service-linked role for Security Center (SAS). Security Center uses this role to access your resources in other Alibaba Cloud services.</description></item>
            /// <item><description><b>AliyunServiceRoleForSasCspm</b>: the service-linked role for Security Center - Cloud Security Posture Management (CSPM). SAS-CSPM uses this role to access your resources in other Alibaba Cloud services.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRoleForWebsiteBuildPublish</para>
            /// </summary>
            [NameInMap("ServiceLinkedRole")]
            [Validation(Required=false)]
            public string ServiceLinkedRole { get; set; }

        }

    }

}
