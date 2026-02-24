// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>A client token. It is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.</para>
        /// <para><c>ClientToken</c> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver compliance snapshots. Cloud Config delivers the compliance and non-compliance information of resources to SLS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver compliance snapshots.</para>
        /// </description></item>
        /// <item><description><para>false: Do not deliver compliance snapshots.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompliantSnapshot")]
        [Validation(Required=false)]
        public bool? CompliantSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver resource configuration histories. When the configuration of a resource changes, Cloud Config delivers the resource configuration history to OSS, SLS, or MNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver resource configuration histories.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver resource configuration histories.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is OSS, you must set at least one of <c>ConfigurationSnapshot</c> (scheduled resource snapshots) and <c>ConfigurationItemChangeNotification</c> (resource configuration histories) to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is SLS, you must set at least one of <c>ConfigurationSnapshot</c> (scheduled resource snapshots), <c>CompliantSnapshot</c> (compliance snapshots), <c>ConfigurationItemChangeNotification</c> (resource configuration histories), and <c>NonCompliantNotification</c> (non-compliant events) to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is MNS, you must set at least one of <c>ConfigurationItemChangeNotification</c> (resource configuration histories) and <c>NonCompliantNotification</c> (non-compliant events) to true.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ConfigurationItemChangeNotification")]
        [Validation(Required=false)]
        public bool? ConfigurationItemChangeNotification { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS or SLS at <c>04:00Z</c> and <c>16:00Z</c> (UTC) every day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver scheduled resource snapshots.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver scheduled resource snapshots.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is OSS, you must set at least one of <c>ConfigurationSnapshot</c> (scheduled resource snapshots) and <c>ConfigurationItemChangeNotification</c> (resource configuration histories) to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is SLS, you must set at least one of <c>ConfigurationSnapshot</c> (scheduled resource snapshots), <c>ConfigurationItemChangeNotification</c> (resource configuration histories), <c>CompliantSnapshot</c> (compliance snapshots), and <c>NonCompliantNotification</c> (non-compliant events) to true.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

        /// <summary>
        /// <para>An additional rule for the delivery channel. Use this rule to specify filter conditions for subscriptions.</para>
        /// <list type="bullet">
        /// <item><description><para>If you subscribe to compliance events, you can specify the minimum risk level and resource types as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>To specify the minimum risk level of events, use <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
        /// <para><c>value</c> specifies the risk level to filter. Valid values: 1 for high, 2 for medium, and 3 for low.</para>
        /// <para><c>multiple</c> specifies whether the filter supports multiple values. The risk level filter supports only a single value. Therefore, set <c>multiple</c> to <c>false</c> when you deliver compliance events.</para>
        /// </description></item>
        /// <item><description><para>To specify the resource types of events, use <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para><c>values</c> specifies the resource types to which you want to subscribe. The value is a JSON array of resource types.
        /// Example:
        /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
        /// <para><c>multiple</c> specifies whether the filter supports multiple values. The resource type filter supports multiple values. If you select multiple resource types, set <c>multiple</c> to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>You can also specify a risk level and resource types at the same time. Example:
        /// <c>[{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;2&quot;,&quot;multiple&quot;:false},{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::CDN::Domain&quot;,&quot;ACS::ActionTrail::Trail&quot;],&quot;multiple&quot;:true}]</c></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you subscribe to resource configuration deliveries, you can specify the resource types as <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para><c>values</c> specifies the resource types that you want to deliver. The value is a JSON array of resource types.
        /// Example:
        /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</para>
        /// </summary>
        [NameInMap("DeliveryChannelCondition")]
        [Validation(Required=false)]
        public string DeliveryChannelCondition { get; set; }

        /// <summary>
        /// <para>The name of the delivery channel.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the value is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testoss</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <para>The ARN of the delivery destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the delivery channel is OSS, the value is in the format of <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c>. Example: <c>acs:oss:cn-shanghai:100931896542****:new-bucket</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel is MNS, the value is in the format of <c>acs:mns:{RegionId}:{accountId}:/topics/{topicName}</c>. Example: <c>acs:mns:cn-shanghai:100931896542****:/topics/topic1</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel is SLS, the value is in the format of <c>acs:log:{RegionId}:{accountId}:project/{projectName}/logstore/{logstoreName}</c>. Example: <c>acs:log:cn-shanghai:100931896542****:project/project1/logstore/logstore1</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
        /// </summary>
        [NameInMap("DeliveryChannelTargetArn")]
        [Validation(Required=false)]
        public string DeliveryChannelTargetArn { get; set; }

        /// <summary>
        /// <para>The type of the delivery channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OSS: Object Storage Service.</para>
        /// </description></item>
        /// <item><description><para>MNS: Simple Message Queue (formerly MNS).</para>
        /// </description></item>
        /// <item><description><para>SLS: Simple Log Service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DeliveryChannelType")]
        [Validation(Required=false)]
        public string DeliveryChannelType { get; set; }

        /// <summary>
        /// <para>The time when Cloud Config starts to deliver scheduled resource snapshots every day.</para>
        /// <para>The value must be in the <c>HH:mmZ</c> format (UTC).</para>
        /// <remarks>
        /// <para>When you enable scheduled resource snapshot delivery, you can use this parameter to customize the delivery time. If you do not set this parameter, the snapshots are delivered at <c>04:00Z</c> and <c>16:00Z</c> (UTC) by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>09:10Z</para>
        /// </summary>
        [NameInMap("DeliverySnapshotTime")]
        [Validation(Required=false)]
        public string DeliverySnapshotTime { get; set; }

        /// <summary>
        /// <para>The description of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My OSS delivery.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver non-compliant events. When a resource is evaluated as non-compliant, Cloud Config delivers the non-compliant event to SLS or MNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver non-compliant events.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver non-compliant events.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is SLS, you must set at least one of <c>ConfigurationSnapshot</c> (scheduled resource snapshots), <c>CompliantSnapshot</c> (compliance snapshots), <c>ConfigurationItemChangeNotification</c> (resource configuration histories), and <c>NonCompliantNotification</c> (non-compliant events) to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel is MNS, you must set at least one of <c>ConfigurationItemChangeNotification</c> (resource configuration histories) and <c>NonCompliantNotification</c> (non-compliant events) to true.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NonCompliantNotification")]
        [Validation(Required=false)]
        public bool? NonCompliantNotification { get; set; }

        /// <summary>
        /// <para>The ARN of the OSS bucket to which the oversized data is delivered when the size of the data exceeds the limit of the delivery channel. The format is <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c>.</para>
        /// <para>If you do not set this parameter, Cloud Config delivers only the summary of the data.</para>
        /// <remarks>
        /// <para>This parameter is supported only for SLS and MNS delivery channels. The delivery channel limit for SLS is 1 MB. The delivery channel limit for MNS is 64 KB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
        /// </summary>
        [NameInMap("OversizedDataOSSTargetArn")]
        [Validation(Required=false)]
        public string OversizedDataOSSTargetArn { get; set; }

    }

}
