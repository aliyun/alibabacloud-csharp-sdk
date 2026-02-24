// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DryRunConfigRuleRequest : TeaModel {
        /// <summary>
        /// <para>The complete configuration information of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ResourceCreationTime&quot;: 1741241360000,
        ///   &quot;AccountId&quot;: 123,
        ///   &quot;Configuration&quot;: {
        ///     &quot;ResourceGroupId&quot;: &quot;&quot;,
        ///     &quot;Memory&quot;: 1024,
        ///     &quot;InstanceChargeType&quot;: &quot;PrePaid&quot;,
        ///     &quot;Cpu&quot;: 1,
        ///     &quot;OSName&quot;: &quot;Alibaba Cloud Linux  3.2104 LTS 64 bit&quot;,
        ///     &quot;InstanceNetworkType&quot;: &quot;vpc&quot;,
        ///     &quot;InnerIpAddress&quot;: {
        ///       &quot;IpAddress&quot;: []
        ///     },
        ///     &quot;ExpiredTime&quot;: &quot;2026-05-06T16:00Z&quot;,
        ///     &quot;ImageId&quot;: &quot;aliyun_3_x64_20G_alibase_20250117.vhd&quot;,
        ///     &quot;EipAddress&quot;: {
        ///       &quot;AllocationId&quot;: &quot;&quot;,
        ///       &quot;IpAddress&quot;: &quot;&quot;,
        ///       &quot;InternetChargeType&quot;: &quot;&quot;
        ///     },
        ///     &quot;ImageOptions&quot;: {},
        ///     &quot;Status&quot;: &quot;Running&quot;,
        ///     &quot;AdditionalInfo&quot;: {},
        ///     &quot;HibernationOptions&quot;: {
        ///       &quot;Configured&quot;: false
        ///     }
        ///   },
        ///   &quot;ResourceId&quot;: &quot;i-bp1d8kd8ztaynb4c****&quot;,
        ///   &quot;ResourceName&quot;: &quot;****&quot;,
        ///   &quot;ResourceStatus&quot;: &quot;Running&quot;,
        ///   &quot;Region&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;AvailabilityZone&quot;: &quot;cn-hangzhou-h&quot;,
        ///   &quot;ResourceType&quot;: &quot;ACS::ECS::Instance&quot;,
        ///   &quot;ResourceDeleted&quot;: 1
        /// }</para>
        /// </summary>
        [NameInMap("ConfigurationItem")]
        [Validation(Required=false)]
        public string ConfigurationItem { get; set; }

        /// <summary>
        /// <para>The resource type that is evaluated by the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
