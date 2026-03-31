// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateConfigDeliveryChannelRequest : TeaModel {
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
        /// <para>Specifies whether to deliver scheduled compliant snapshots. Cloud Config delivers scheduled compliant snapshots at <c>04:00Z</c> and <c>16:00Z</c> to Log Service every day. The time is displayed in UTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cloud Config delivers scheduled compliant snapshots.</description></item>
        /// <item><description>false (default): Cloud Config does not deliver scheduled compliant snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
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
        /// </summary>
        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

        /// <summary>
        /// <para>The rule that you want to attach to the delivery channel, used to specify subscription content filtering conditions.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify the minimum risk level and resource types for compliance events, it should be as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>The setting of the lowest risk level for the events to which you want to subscribe is in the following format: <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
        /// <para>The <c>value</c> field indicates the lowest risk level of the events to which you want to subscribe. Valid values: 1, 2, and 3. The value 1 indicates the high risk level, the value 2 indicates the medium risk level, and the value 3 indicates the low risk level.</para>
        /// <para>The <c>multiple</c> field indicates whether multiple values are supported for this group of filters. Risk levels only support single-value filtering, so the multiple field for compliance event type content can only be set to <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para>The setting of the resource types of the events to which you want to subscribe is in the following format: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para>The <c>values</c> field indicates the resource types of the events to which you want to subscribe. </para>
        /// <para>The <c>multiple</c> field indicates whether multiple values are supported for this group of filters. Resource types support multi-value filtering; when selecting multiple resource types, the multiple field can be set to true.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The value of the field is a JSON array. Examples:</para>
        /// <pre><c>    `[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]`
        /// 
        /// *   You can also simultaneously specify both risk levels and resource types, such as:
        /// 
        ///     `[{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;2&quot;,&quot;multiple&quot;:false},{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::CDN::Domain&quot;,&quot;ACS::ActionTrail::Trail&quot;],&quot;multiple&quot;:true}]`
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>If you specify the resource types for delivering configurations, the resource types are specified by: <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para>The <c>values</c> field specifies the resource types of the snapshots to which you want to deliver. The value of the field is a JSON array. Examples:</para>
        /// <para>  <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
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
        /// <para>If you do not configure this parameter, this parameter is left empty.</para>
        /// </remarks>
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
        /// <item><description>OSS: Object Storage Service (OSS)</description></item>
        /// <item><description>MNS: Message Service (MNS)</description></item>
        /// <item><description>SLS: Log Service</description></item>
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

    }

}
