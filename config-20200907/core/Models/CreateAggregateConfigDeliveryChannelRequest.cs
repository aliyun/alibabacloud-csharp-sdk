// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-a4e5626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>A client-generated token that you can use to ensure the idempotence of the request. You must make sure that the token is unique for each request.</para>
        /// <para>The <c>ClientToken</c> parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver compliance snapshots. Cloud Config delivers information about the compliance and non-compliance of resources to SLS. Valid values:</para>
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
        /// <para>Specifies whether to deliver the resource configuration change history. If the configurations of a resource change, Cloud Config delivers the configuration change history to OSS, SLS, or MNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver the resource configuration change history.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver the resource configuration change history.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is OSS, you must set at least one of the \<c>ConfigurationSnapshot\\</c> and \<c>ConfigurationItemChangeNotification\\</c> parameters to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is SLS, you must set at least one of the \<c>ConfigurationSnapshot\\</c>, \<c>ConfigurationItemChangeNotification\\</c>, and \<c>NonCompliantNotification\\</c> parameters to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is MNS, you must set at least one of the \<c>ConfigurationItemChangeNotification\\</c> and \<c>NonCompliantNotification\\</c> parameters to true.</description></item>
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
        /// <para>Specifies whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS, SLS, or MNS at <c>04:00Z</c> and <c>16:00Z</c> (UTC) every day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver scheduled resource snapshots.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver scheduled resource snapshots.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is OSS, you must set at least one of the \<c>ConfigurationSnapshot\\</c> and \<c>ConfigurationItemChangeNotification\\</c> parameters to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is SLS, you must set at least one of the \<c>ConfigurationSnapshot\\</c>, \<c>ConfigurationItemChangeNotification\\</c>, and \<c>NonCompliantNotification\\</c> parameters to true.</description></item>
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
        /// <para>The rule that is used to filter events or resources for the delivery channel. This parameter is supported for all deliveries to MNS channels and for snapshot deliveries to SLS channels.</para>
        /// <list type="bullet">
        /// <item><description><para>For an MNS channel, you can specify the following rules to filter events:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum risk level of the events to which you want to subscribe is <c>{&quot;filterType&quot;:&quot;RuleRiskLevel&quot;,&quot;value&quot;:&quot;1&quot;,&quot;multiple&quot;:false}</c>.</para>
        /// <para>The \<c>value\\</c> parameter specifies the risk level. Valid values: 1, 2, and 3. The value 1 indicates high risk. The value 2 indicates medium risk. The value 3 indicates low risk.</para>
        /// </description></item>
        /// <item><description><para>The resource types of the events to which you want to subscribe are <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para>The \<c>values\\</c> parameter specifies the resource types of the events to which you want to subscribe. The value of this parameter is a JSON array of strings.
        /// Example:
        /// <c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For an SLS channel, you can specify the following rule to filter snapshots:</para>
        /// <para>The resource types of the snapshots to be delivered are <c>{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ACK::Cluster&quot;,&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;],&quot;multiple&quot;:true}</c>.</para>
        /// <para><c>[{&quot;filterType&quot;:&quot;ResourceType&quot;,&quot;values&quot;:[&quot;ACS::ActionTrail::Trail&quot;,&quot;ACS::CBWP::CommonBandwidthPackage&quot;,&quot;ACS::CDN::Domain&quot;,&quot;ACS::CEN::CenBandwidthPackage&quot;,&quot;ACS::CEN::CenInstance&quot;,&quot;ACS::CEN::Flowlog&quot;,&quot;ACS::DdosCoo::Instance&quot;],&quot;multiple&quot;:true}]</c></para>
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
        /// <para>If you do not set this parameter, this parameter is empty.</para>
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
        /// <item><description><para>If the delivery channel type is OSS, the value of this parameter is in the <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c> format. Example: <c>acs:oss:cn-shanghai:100931896542****:new-bucket</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel type is MNS, the value of this parameter is in the <c>acs:mns:{RegionId}:{accountId}:/topics/{topicName}</c> format. Example: <c>acs:mns:cn-shanghai:100931896542****:/topics/topic1</c>.</para>
        /// </description></item>
        /// <item><description><para>If the delivery channel type is SLS, the value of this parameter is in the <c>acs:log:{RegionId}:{accountId}:project/{projectName}/logstore/{logstoreName}</c> format. Example: <c>acs:log:cn-shanghai:100931896542****:project/project1/logstore/logstore1</c>.</para>
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
        /// <item><description><para>OSS: Object Storage Service</para>
        /// </description></item>
        /// <item><description><para>MNS: Simple Message Queue</para>
        /// </description></item>
        /// <item><description><para>SLS: Simple Log Service</para>
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
        /// <para>The time of day from which scheduled resource snapshots are delivered. The time is displayed in UTC.</para>
        /// <para>The value is in the <c>HH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>If you enable the scheduled delivery of resource snapshots, you can use this parameter to customize the delivery time. If you do not set this parameter, the snapshots are delivered at <c>04:00Z</c> and <c>16:00Z</c> every day by default.</para>
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
        /// <para>Specifies whether to deliver resource non-compliance events. If a resource is evaluated as non-compliant, Cloud Config delivers the non-compliance event to SLS or MNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deliver resource non-compliance events.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not deliver resource non-compliance events.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is SLS, you must set at least one of the \<c>ConfigurationSnapshot\\</c>, \<c>ConfigurationItemChangeNotification\\</c>, and \<c>NonCompliantNotification\\</c> parameters to true.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the delivery channel type is MNS, you must set at least one of the \<c>ConfigurationItemChangeNotification\\</c> and \<c>NonCompliantNotification\\</c> parameters to true.</description></item>
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
        /// <para>The ARN of the OSS bucket that is used to store oversized data to be delivered when the size of the data exceeds the specified limit of the delivery channel. The value is in the <c>acs:oss:{RegionId}:{accountId}:{bucketName}</c> format.</para>
        /// <para>If you do not set this parameter, Cloud Config delivers only summary information.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to delivery channels of the SLS or MNS type. The maximum size of data that can be delivered to an SLS Logstore is 1 MB. The maximum size of data that can be delivered to an MNS topic is 64 KB.</para>
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
