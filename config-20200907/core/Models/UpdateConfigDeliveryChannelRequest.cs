// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. Use a client to generate the token, and make sure that the token is unique among different requests.</para>
        /// <para>The <c>ClientToken</c> parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver resource compliance snapshots. Cloud Config delivers resource compliance and non-compliance information to SLS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The resource compliance snapshots are delivered.</para>
        /// </description></item>
        /// <item><description><para>false: The resource compliance snapshots are not delivered.</para>
        /// </description></item>
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
        /// <para>Specifies whether to deliver the resource configuration history. Cloud Config delivers the resource configuration history to OSS, SLS, or MNS when the configuration of a resource changes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The resource configuration history is delivered.</para>
        /// </description></item>
        /// <item><description><para>false (default): The resource configuration history is not delivered.</para>
        /// </description></item>
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
        /// <para>Specifies whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS or SLS at <c>04:00Z</c> and <c>16:00Z</c> (UTC) every day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The scheduled resource snapshots are delivered.</para>
        /// </description></item>
        /// <item><description><para>false (default): The scheduled resource snapshots are not delivered.</para>
        /// </description></item>
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
        /// <para>The rule that is attached to the delivery channel. This parameter is applicable to all deliveries to MNS and snapshot deliveries to SLS.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify the minimum risk level of events and the resource types for an MNS subscription, use the following formats:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum risk level of the subscribed events: <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
        /// <para><c>value</c> specifies the risk level. Valid values: 1 (high risk), 2 (medium risk), and 3 (low risk).</para>
        /// </description></item>
        /// <item><description><para>The resource types of the subscribed events: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para><c>values</c> specifies the resource types of the subscribed events. The value is a JSON array.
        /// Example:
        /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you specify the resource types of snapshots delivered to SLS, use the following format: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para><c>values</c> specifies the resource types of the snapshots to deliver. The value is a JSON array.
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
        /// <para>For more information about how to obtain the delivery channel ID, see <a href="https://help.aliyun.com/document_detail/429841.html">ListConfigDeliveryChannels</a>.</para>
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
        /// <item><description><para>If the delivery channel is Object Storage Service (OSS), the value is in the format of <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c>. Example: <c>acs:oss:cn-shanghai:100931896542****:new-bucket</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel is MNS, the value is in the format of <c>acs:mns:{RegionId}:{accountId}:/topics/{topicName}</c>. Example: <c>acs:mns:cn-shanghai:100931896542****:/topics/topic1</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel is Simple Log Service (SLS), the value is in the format of <c>acs:log:{RegionId}:{accountId}:project/{projectName}/logstore/{logstoreName}</c>. Example: <c>acs:log:cn-shanghai:100931896542****:project/project1/logstore/logstore1</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:100931896542****:new-bucket</para>
        /// </summary>
        [NameInMap("DeliveryChannelTargetArn")]
        [Validation(Required=false)]
        public string DeliveryChannelTargetArn { get; set; }

        /// <summary>
        /// <para>The time of day when the scheduled resource snapshot is delivered.</para>
        /// <para>The value is in the <c>HH:mmZ</c> format. The time is in UTC.</para>
        /// <remarks>
        /// <para>If you enable scheduled delivery of resource snapshots, use this parameter to specify a delivery time. If you do not specify this parameter, Cloud Config delivers the scheduled resource snapshots at <c>04:00Z</c> and <c>16:00Z</c> by default.</para>
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
        /// <para>Specifies whether to deliver resource non-compliance events. Cloud Config delivers resource non-compliance events to SLS or MNS when a resource is evaluated as non-compliant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The resource non-compliance events are delivered.</para>
        /// </description></item>
        /// <item><description><para>false (default): The resource non-compliance events are not delivered.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for delivery channels of the SLS and MNS types.</para>
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
        /// <para>The ARN of the OSS bucket where data is delivered when the data size exceeds the limit of the delivery channel. The value is in the format of <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c>.</para>
        /// <para>If you do not specify this parameter, Cloud Config delivers only the summary of the data.</para>
        /// <remarks>
        /// <para>This parameter is available only for delivery channels of the SLS and MNS types. The maximum size of data that can be delivered to SLS is 1 MB. The maximum size of data that can be delivered to MNS is 64 KB.</para>
        /// </remarks>
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
        /// <item><description><para>0: The delivery channel is disabled. Cloud Config retains the most recent delivery configuration and stops delivering resource data.</para>
        /// </description></item>
        /// <item><description><para>1 (default): The delivery channel is enabled.</para>
        /// </description></item>
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
