// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigDeliveryChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of delivery channels.</para>
        /// </summary>
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<ListConfigDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class ListConfigDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            /// <summary>
            /// <para>The ID of the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to receive compliance snapshots. Cloud Config delivers resource compliance and non-compliance information to SLS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Receive compliance snapshots.</para>
            /// </description></item>
            /// <item><description><para>false: Do not receive compliance snapshots.</para>
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
            /// <para>Specifies whether to receive the resource configuration history. When a resource configuration changes, Cloud Config delivers the resource configuration history to OSS, SLS, or MNS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Receive the resource configuration history.</para>
            /// </description></item>
            /// <item><description><para>false: Do not receive the resource configuration history.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigurationItemChangeNotification")]
            [Validation(Required=false)]
            public bool? ConfigurationItemChangeNotification { get; set; }

            /// <summary>
            /// <para>Specifies whether to receive scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS or SLS at <c>04:00Z</c> and <c>16:00Z</c> (UTC) every day. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Receive scheduled resource snapshots.</para>
            /// </description></item>
            /// <item><description><para>false: Do not receive scheduled resource snapshots.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigurationSnapshot")]
            [Validation(Required=false)]
            public bool? ConfigurationSnapshot { get; set; }

            /// <summary>
            /// <para>The ARN of the role that is assumed by the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::120886317861****:role/aliyunserviceroleforconfig</para>
            /// </summary>
            [NameInMap("DeliveryChannelAssumeRoleArn")]
            [Validation(Required=false)]
            public string DeliveryChannelAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The rule attached to the delivery channel. This parameter is supported for MNS channels and for snapshot delivery to SLS channels.</para>
            /// <list type="bullet">
            /// <item><description><para>To subscribe to MNS events, specify the minimum risk level and resource types:</para>
            /// <list type="bullet">
            /// <item><description><para>Minimum risk level of subscribed events: <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
            /// <para>\<c>value\\</c> specifies the risk level. Valid values: 1 (high risk), 2 (medium risk), and 3 (low risk).</para>
            /// </description></item>
            /// <item><description><para>Resource types of subscribed events: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>\<c>values\\</c> is a JSON array of the resource types.
            /// Example:
            /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>To deliver snapshots to SLS, specify the resource types: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>\<c>values\\</c> is a JSON array of the resource types.
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
            /// <para>The ID of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdc-d9106457e0d900b1****</para>
            /// </summary>
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            /// <summary>
            /// <para>The name of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDeliveryChannel</para>
            /// </summary>
            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the delivery destination.</para>
            /// <list type="bullet">
            /// <item><description><para>If \<c>DeliveryChannelType\\</c> is \<c>OSS\\</c>, this parameter is the ARN of an OSS bucket.</para>
            /// </description></item>
            /// <item><description><para>If \<c>DeliveryChannelType\\</c> is \<c>MNS\\</c>, this parameter is the ARN of an MNS topic.</para>
            /// </description></item>
            /// <item><description><para>If \<c>DeliveryChannelType\\</c> is \<c>SLS\\</c>, this parameter is the ARN of an SLS Logstore.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:oss:cn-shanghai:120886317861****:new-bucket</para>
            /// </summary>
            [NameInMap("DeliveryChannelTargetArn")]
            [Validation(Required=false)]
            public string DeliveryChannelTargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OSS: Object Storage Service (OSS).</para>
            /// </description></item>
            /// <item><description><para>MNS: Simple Message Queue (formerly MNS).</para>
            /// </description></item>
            /// <item><description><para>SLS: Simple Log Service (SLS).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DeliveryChannelType")]
            [Validation(Required=false)]
            public string DeliveryChannelType { get; set; }

            /// <summary>
            /// <para>The time when scheduled resource snapshots start to be delivered every day.</para>
            /// <para>The format is <c>HH:mmZ</c> (UTC).</para>
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
            /// <para>Specifies whether to receive resource non-compliance events. When a resource becomes non-compliant, Cloud Config delivers a resource non-compliance event to SLS or MNS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Receive resource non-compliance events.</para>
            /// </description></item>
            /// <item><description><para>false: Do not receive resource non-compliance events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NonCompliantNotification")]
            [Validation(Required=false)]
            public bool? NonCompliantNotification { get; set; }

            /// <summary>
            /// <para>The destination OSS bucket to which the data is transferred when the size of the data exceeds the limit of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
            /// </summary>
            [NameInMap("OversizedDataOSSTargetArn")]
            [Validation(Required=false)]
            public string OversizedDataOSSTargetArn { get; set; }

            /// <summary>
            /// <para>The status of the delivery channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The delivery channel is disabled.</para>
            /// </description></item>
            /// <item><description><para>1: The delivery channel is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC300244-FCE3-5061-8214-C27ECB668487</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
