// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1739345768000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741795200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt-cn-xxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt-cn-xxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// <list type="bullet">
            /// <item><description><para>0: Preparing</para>
            /// </description></item>
            /// <item><description><para>5: In Service</para>
            /// </description></item>
            /// <item><description><para>7: Upgrading</para>
            /// </description></item>
            /// <item><description><para>15: Frozen</para>
            /// </description></item>
            /// <item><description><para>10: Released</para>
            /// </description></item>
            /// <item><description><para>1: Not Activated</para>
            /// </description></item>
            /// <item><description><para>2: Overdue</para>
            /// </description></item>
            /// <item><description><para>3: Expired</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }

            /// <summary>
            /// <para>The instance type:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Basic Edition</para>
            /// </description></item>
            /// <item><description><para>1: Platinum Edition</para>
            /// </description></item>
            /// <item><description><para>2: Pay-as-you-go</para>
            /// </description></item>
            /// <item><description><para>3: Subscription Lightweight</para>
            /// </description></item>
            /// <item><description><para>4: Professional Edition</para>
            /// </description></item>
            /// <item><description><para>5: Serverless Edition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }

            /// <summary>
            /// <para>The Milvus version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V3.3.0</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("MqttTags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesMqttTags> MqttTags { get; set; }
            public class ListInstancesResponseBodyInstancesMqttTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>245949616640095</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The instance type of the Professional Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.p2.1xlarge</para>
            /// </summary>
            [NameInMap("Specific")]
            [Validation(Required=false)]
            public string Specific { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>294F5B26-FADF-41D0-BE68-14ABE4EB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
