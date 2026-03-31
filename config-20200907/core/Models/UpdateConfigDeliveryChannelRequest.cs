// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must ensure that the token is unique among different requests.</para>
        /// <para>The <c>token</c> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver scheduled compliant snapshots. Cloud Config delivers scheduled compliant snapshots at <c>04:00Z</c> and <c>16:00Z</c> to  Log Service every day. The time is displayed in UTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cloud Config delivers compliant snapshots.</description></item>
        /// <item><description>false (default): Cloud Config does not deliver scheduled compliant snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("CompliantSnapshot")]
        [Validation(Required=false)]
        public bool? CompliantSnapshot { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver resource change logs. If you set this parameter to true, Cloud Config delivers resource change logs to OSS, Log Service, or MNS when the configurations of the resources change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cloud Config delivers resource change logs.</description></item>
        /// <item><description>false (default): Cloud Config does not deliver resource change logs.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available for delivery channels of the OSS, SLS, and MNS types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ConfigurationItemChangeNotification")]
        [Validation(Required=false)]
        public bool? ConfigurationItemChangeNotification { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots at <c>04:00Z</c> and <c>16:00Z</c> to OSS, MNS, or Log Service every day. The time is displayed in UTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cloud Config delivers scheduled resource snapshots.</description></item>
        /// <item><description>false (default): Cloud Config does not deliver scheduled resource snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

        /// <summary>
        /// <para>The rule that you want to attach to the delivery channel. This parameter is available when you deliver data of all types to MNS or deliver snapshots to Log Service.</para>
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
        /// <para>For more information about how to obtain the ID of a delivery channel, see <a href="https://help.aliyun.com/document_detail/429841.html">DescribeDeliveryChannels</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdc-8e45ff4e06a3a8****</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <para>The name of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testoss</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the delivery destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>acs:oss:{RegionId}:{accountId}:{bucketName}</c> if your delivery destination is an OSS bucket. Example: <c>acs:oss:cn-shanghai:100931896542****:new-bucket</c>.</description></item>
        /// <item><description><c>acs:mns:{RegionId}:{accountId}:/topics/{topicName}</c> if your delivery destination is an MNS topic. Example: <c>acs:mns:cn-shanghai:100931896542****:/topics/topic1</c>.</description></item>
        /// <item><description><c>acs:log:{RegionId}:{accountId}:project/{projectName}/logstore/{logstoreName}</c> if your delivery destination is a Log Service Logstore. Example: <c>acs:log:cn-shanghai:100931896542****:project/project1/logstore/logstore1</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
        /// </summary>
        [NameInMap("DeliveryChannelTargetArn")]
        [Validation(Required=false)]
        public string DeliveryChannelTargetArn { get; set; }

        /// <summary>
        /// <para>The time when you want Cloud Config to deliver scheduled resource snapshots every day.</para>
        /// <para>Format: <c>HH:mmZ</c>. This time is displayed in UTC.</para>
        /// <remarks>
        /// <para>When you enable the scheduled resource delivery feature, you can configure this parameter to specify a custom delivery time. If you do not configure this parameter, Cloud Config automatically delivers scheduled resource snapshots at <c>04:00Z</c> and <c>16:00Z</c> every day.</para>
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
        /// <para>Specifies whether to deliver resource non-compliance events. If you set this parameter to true, Cloud Config delivers resource non-compliance events to Log Service or MNS when resources are considered non-compliant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cloud Config delivers resource non-compliance events.</description></item>
        /// <item><description>false (default): Cloud Config does not deliver resource non-compliance events.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for delivery channels of the SLS or MNS type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("NonCompliantNotification")]
        [Validation(Required=false)]
        public bool? NonCompliantNotification { get; set; }

        /// <summary>
        /// <para>The ARN of the OSS bucket to which you want to transfer the delivery data when the size of the data exceeds the specified upper limit of the delivery channel. Format: <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c>.</para>
        /// <para>If you do not configure this parameter, Cloud Config delivers only summary data.</para>
        /// <remarks>
        /// <para>This parameter is available only for delivery channels of the SLS or MNS type. The maximum storage size of delivery channels of the SLS type is 1 MB, and the maximum storage size of delivery channels of the MNS type is 64 KB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
        /// </summary>
        [NameInMap("OversizedDataOSSTargetArn")]
        [Validation(Required=false)]
        public string OversizedDataOSSTargetArn { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the delivery channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Cloud Config disables the delivery channel. Cloud Config retains the most recent delivery configuration and stops resource data delivery.</description></item>
        /// <item><description>1 (default): Cloud Config enables the delivery channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
