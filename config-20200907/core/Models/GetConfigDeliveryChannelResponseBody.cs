// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigDeliveryChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannel")]
        [Validation(Required=false)]
        public GetConfigDeliveryChannelResponseBodyDeliveryChannel DeliveryChannel { get; set; }
        public class GetConfigDeliveryChannelResponseBodyDeliveryChannel : TeaModel {
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
            /// <para>Indicates whether to deliver compliance snapshots. Cloud Config delivers compliance and non-compliance information of resources to SLS. Valid values:</para>
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
            /// <para>Indicates whether to deliver resource configuration changes. When the configuration of a resource changes, Cloud Config delivers the resource configuration changes to OSS, SLS, or MNS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Deliver resource configuration changes.</para>
            /// </description></item>
            /// <item><description><para>false: Do not deliver resource configuration changes.</para>
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
            /// <para>Indicates whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS or SLS at <c>04:00Z</c> and <c>16:00Z</c> (UTC) every day. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Deliver scheduled resource snapshots.</para>
            /// </description></item>
            /// <item><description><para>false: Do not deliver scheduled resource snapshots.</para>
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
            /// <para>The rule that is attached to the delivery channel. This parameter is available only for delivery channels of the MNS type and for snapshot deliveries to delivery channels of the SLS type.</para>
            /// <list type="bullet">
            /// <item><description><para>If you deliver data to an MNS topic, you can specify the lowest risk level of the events to subscribe to and the resource types to subscribe to.</para>
            /// <list type="bullet">
            /// <item><description><para>The lowest risk level of the events to subscribe to: <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
            /// <para>The \<c>value\\</c> parameter indicates the risk level. Valid values: 1 (high), 2 (medium), and 3 (low).</para>
            /// </description></item>
            /// <item><description><para>The resource types to subscribe to: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>The \<c>values\\</c> parameter indicates the resource types. The value is a JSON array.
            /// Example:
            /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you deliver snapshots to an SLS Logstore, you can specify the resource types to deliver: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>The \<c>values\\</c> parameter indicates the resource types. The value is a JSON array.
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
            /// <item><description><para>If the DeliveryChannelType parameter is set to OSS, this parameter is the ARN of the destination OSS bucket.</para>
            /// </description></item>
            /// <item><description><para>If the DeliveryChannelType parameter is set to MNS, this parameter is the ARN of the destination MNS topic.</para>
            /// </description></item>
            /// <item><description><para>If the DeliveryChannelType parameter is set to SLS, this parameter is the ARN of the destination Simple Log Service Logstore.</para>
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
            /// <item><description><para>OSS: Object Storage Service.</para>
            /// </description></item>
            /// <item><description><para>MNS: Simple Message Queue (formerly MNS).</para>
            /// </description></item>
            /// <item><description><para>SLS: Simple Log Service.</para>
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
            /// <para>The time when Cloud Config starts to deliver scheduled resource snapshots every day.</para>
            /// <para>The time is in the <c>HH:mmZ</c> format (UTC).</para>
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
            /// <para>Indicates whether to deliver resource non-compliance events. When a resource is evaluated as non-compliant, Cloud Config delivers the non-compliance events to SLS or MNS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Deliver resource non-compliance events.</para>
            /// </description></item>
            /// <item><description><para>false: Do not deliver resource non-compliance events.</para>
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
            /// <para>The ARN of the OSS bucket to which the delivered data is transferred when the size of the data exceeds the limit of the delivery channel.</para>
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
