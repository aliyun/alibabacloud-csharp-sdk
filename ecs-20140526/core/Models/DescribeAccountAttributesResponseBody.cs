// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about account privileges in the specified region.</para>
        /// </summary>
        [NameInMap("AccountAttributeItems")]
        [Validation(Required=false)]
        public DescribeAccountAttributesResponseBodyAccountAttributeItems AccountAttributeItems { get; set; }
        public class DescribeAccountAttributesResponseBodyAccountAttributeItems : TeaModel {
            [NameInMap("AccountAttributeItem")]
            [Validation(Required=false)]
            public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem> AccountAttributeItem { get; set; }
            public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem : TeaModel {
                /// <summary>
                /// <para>The type of the resource quota in the specified region. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>instance-network-type: the available network types.</description></item>
                /// <item><description>max-security-groups: the maximum number of security groups.</description></item>
                /// <item><description>max-elastic-network-interfaces: the maximum number of ENIs.</description></item>
                /// <item><description>max-postpaid-instance-vcpu-count: the maximum number of vCPUs for pay-as-you-go instances.</description></item>
                /// <item><description>max-spot-instance-vcpu-count: the maximum number of vCPUs for spot instances.</description></item>
                /// <item><description>used-postpaid-instance-vcpu-count: the number of vCPUs that were allocated to pay-as-you-go instances.</description></item>
                /// <item><description>used-spot-instance-vcpu-count: the number of vCPUs that were allocated to spot instances.</description></item>
                /// <item><description>max-postpaid-yundisk-capacity: the maximum capacity of pay-as-you-go data disks. (The value is deprecated.)</description></item>
                /// <item><description>used-postpaid-yundisk-capacity: the capacity of pay-as-you-go data disks that were created. (The value is deprecated.)</description></item>
                /// <item><description>max-dedicated-hosts: the maximum number of dedicated hosts.</description></item>
                /// <item><description>supported-postpaid-instance-types: the instance types of pay-as-you-go I/O optimized instances.</description></item>
                /// <item><description>max-axt-command-count: the maximum number of Cloud Assistant commands.</description></item>
                /// <item><description>max-axt-invocation-daily: the maximum number of Cloud Assistant command executions per day.</description></item>
                /// <item><description>real-name-authentication: whether the account completed the real-name verification.</description></item>
                /// <item><description>max-cloud-assistant-activation-count: the maximum number of activation codes that can be created to use to register managed instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>max-security-groups</para>
                /// </summary>
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                /// <summary>
                /// <para>The values of resource quotas.</para>
                /// </summary>
                [NameInMap("AttributeValues")]
                [Validation(Required=false)]
                public DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues AttributeValues { get; set; }
                public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues : TeaModel {
                    [NameInMap("ValueItem")]
                    [Validation(Required=false)]
                    public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem> ValueItem { get; set; }
                    public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem : TeaModel {
                        /// <summary>
                        /// <para>The number of privilege attributes in the account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The data disk category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>cloud_efficiency: ultra disk</description></item>
                        /// <item><description>cloud_ssd: standard SSD</description></item>
                        /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cloud_ssd</para>
                        /// </summary>
                        [NameInMap("DiskCategory")]
                        [Validation(Required=false)]
                        public string DiskCategory { get; set; }

                        /// <summary>
                        /// <para>The expiration time of a privilege. This parameter is returned only when the account privilege has an expiration time. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-01-01T12:30:00Z</para>
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// <para>The billing method of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrePaid</para>
                        /// </summary>
                        [NameInMap("InstanceChargeType")]
                        [Validation(Required=false)]
                        public string InstanceChargeType { get; set; }

                        /// <summary>
                        /// <para>The type of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.g5.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The value of the resource quota in the specified region. Valid values:</para>
                        /// <para>The values returned for the resource quotas to which the following AttributeName values correspond are 0 or positive integers:</para>
                        /// <list type="bullet">
                        /// <item><description>max-security-groups</description></item>
                        /// <item><description>max-elastic-network-interfaces</description></item>
                        /// <item><description>max-postpaid-instance-vcpu-count</description></item>
                        /// <item><description>max-spot-instance-vcpu-count</description></item>
                        /// <item><description>used-postpaid-instance-vcpu-count</description></item>
                        /// <item><description>used-spot-instance-vcpu-count</description></item>
                        /// <item><description>max-postpaid-yundisk-capacity (the value is deprecated)</description></item>
                        /// <item><description>used-postpaid-yundisk-capacity (the value is deprecated)</description></item>
                        /// <item><description>max-dedicated-hosts</description></item>
                        /// <item><description>max-axt-command-count</description></item>
                        /// <item><description>max-axt-invocation-daily</description></item>
                        /// <item><description>max-cloud-assistant-activation-count</description></item>
                        /// </list>
                        /// <para>When AttributeName is set to supported-postpay-instance-types, instance types are returned. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
                        /// <para>When AttributeName is set to real-name-authentications, one of the following values is returned:</para>
                        /// <list type="bullet">
                        /// <item><description>yes</description></item>
                        /// <item><description>none</description></item>
                        /// <item><description>unnecessary</description></item>
                        /// </list>
                        /// <para>When AttributeName is set to instance-network-type, one of the following values is returned:</para>
                        /// <list type="bullet">
                        /// <item><description>vpc</description></item>
                        /// <item><description>classic</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>800</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>The ID of the zone in which the resource resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-b</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CE45CD5-31FB-47C2-959D-CA8144CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
