// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeServiceLinkedRoleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
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
        public DescribeServiceLinkedRoleStatusRequestSdkRequest SdkRequest { get; set; }
        public class DescribeServiceLinkedRoleStatusRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The service-linked role. Default value: <b>AliyunServiceRoleForSas</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AliyunServiceRoleForSas</b>: the service-linked role for Security Center (sas). Security Center uses this role to access your resources in other Alibaba Cloud services.</description></item>
            /// <item><description><b>AliyunServiceRoleForSasCspm</b>: the service-linked role for Security Center - CSPM (sas-cspm). sas-cspm uses this role to access your resources in other Alibaba Cloud services.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRoleForSas</para>
            /// </summary>
            [NameInMap("ServiceLinkedRole")]
            [Validation(Required=false)]
            public string ServiceLinkedRole { get; set; }

        }

    }

}
