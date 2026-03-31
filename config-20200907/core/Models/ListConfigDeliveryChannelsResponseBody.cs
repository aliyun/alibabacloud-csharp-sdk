// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigDeliveryChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the delivery channels.</para>
        /// </summary>
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<ListConfigDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class ListConfigDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            /// <summary>
            /// <para>The ID of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether the specified destination receives scheduled compliant snapshots. Cloud Config delivers scheduled compliant snapshots at <c>04:00Z</c> and <c>16:00Z</c> to  Log Service every day. The time is displayed in UTC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The specified destination receives scheduled compliant snapshots.</description></item>
            /// <item><description>false: The specified destination does not receive scheduled compliant snapshots.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CompliantSnapshot")]
            [Validation(Required=false)]
            public bool? CompliantSnapshot { get; set; }

            /// <summary>
            /// <para>Indicates whether the specified destination receives resource change logs. If the value of this parameter is true, Cloud Config delivers the resource change logs to OSS, Log Service, or MNS when the configurations of the resources change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The specified destination receives resource change logs.</description></item>
            /// <item><description>false: The specified destination does not receive resource change logs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigurationItemChangeNotification")]
            [Validation(Required=false)]
            public bool? ConfigurationItemChangeNotification { get; set; }

            /// <summary>
            /// <para>Indicates whether the specified destination receives scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots at <c>04:00Z</c> and <c>16:00Z</c> to OSS, MNS, or Log Service every day. The time is displayed in UTC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The specified destination receives scheduled resource snapshots.</description></item>
            /// <item><description>false: The specified destination does not receive scheduled resource snapshots.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigurationSnapshot")]
            [Validation(Required=false)]
            public bool? ConfigurationSnapshot { get; set; }

            /// <summary>
            /// <para>The ARN of the role assumed by the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::120886317861****:role/aliyunserviceroleforconfig</para>
            /// </summary>
            [NameInMap("DeliveryChannelAssumeRoleArn")]
            [Validation(Required=false)]
            public string DeliveryChannelAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The rule that is attached to the delivery channel. This parameter is available when you deliver data of all types to MNS or deliver snapshots to Log Service.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value of the DeliveryChannelType parameter is MNS, take note of the following settings of the lowest risk level and resource types of the events to which you subscribed:</para>
            /// <list type="bullet">
            /// <item><description><para>The setting of the lowest risk level for the events to which you want to subscribe is in the following format: <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
            /// <para>The <c>value</c> field indicates the lowest risk level of the events to which you want to subscribe. Valid values: 1, 2, and 3. The value 1 indicates the high risk level, the value 2 indicates the medium risk level, and the value 3 indicates the low risk level.</para>
            /// </description></item>
            /// <item><description><para>The setting of the resource types of the events to which you want to subscribe is in the following format: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>The <c>values</c> field indicates the resource types of the events to which you want to subscribe. The value of the field is a JSON array. Examples:</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para><c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
            /// <list type="bullet">
            /// <item><description><para>If you set the DeliveryChannelType parameter to SLS, the setting of the resource types of the snapshots to which you want to deliver is in the following format: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
            /// <para>The <c>values</c> field specifies the resource types of the snapshots to which you want to deliver. The value of the field is a JSON array. Examples:</para>
            /// </description></item>
            /// </list>
            /// <para><c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
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
            /// <item><description>If the value of the DeliveryChannelType parameter is OSS, the value of this parameter is the ARN of the destination OSS bucket.</description></item>
            /// <item><description>If the value of the DeliveryChannelType parameter is MNS, the value of this parameter is the ARN of the destination MNS topic.</description></item>
            /// <item><description>If the value of the DeliveryChannelType parameter is SLS, the value of this parameter is the ARN of the destination Log Service Logstore.</description></item>
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
            /// <item><description>OSS: Object Storage Service (OSS)</description></item>
            /// <item><description>MNS: Message Service (MNS)</description></item>
            /// <item><description>SLS: Log Service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DeliveryChannelType")]
            [Validation(Required=false)]
            public string DeliveryChannelType { get; set; }

            /// <summary>
            /// <para>The time when Cloud Config delivers scheduled resources snapshots every day.</para>
            /// <para>Format: <c>HH:mmZ</c>. This time is displayed in UTC.</para>
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
            /// <para>Indicates whether the specified destination receives resource non-compliance events. If the value of this parameter is true, Cloud Config delivers resource non-compliance events to Log Service or MNS when resources are evaluated as non-compliant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The specified destination receives resource non-compliance events.</description></item>
            /// <item><description>false: The specified destination does not receive resource non-compliance events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NonCompliantNotification")]
            [Validation(Required=false)]
            public bool? NonCompliantNotification { get; set; }

            /// <summary>
            /// <para>The ARN of the OSS bucket to which you want to transfer the delivery data when the size of the data exceeds the specified upper limit of the delivery channel.</para>
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
            /// <item><description>0: The delivery channel is disabled.</description></item>
            /// <item><description>1: The delivery channel is enabled.</description></item>
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
