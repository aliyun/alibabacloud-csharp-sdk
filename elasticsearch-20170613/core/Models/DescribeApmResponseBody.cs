// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeApmResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97597D87-8066-5493-B692-5C50DA236D68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeApmResponseBodyResult Result { get; set; }
        public class DescribeApmResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Instance domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apm-cn-i7m2fuae****.apm.elasticsearch.aliyuncs.com:8200</para>
            /// </summary>
            [NameInMap("apmServerDomain")]
            [Validation(Required=false)]
            public string ApmServerDomain { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-16T07:15:51.967Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Deployed replica count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deployedReplica")]
            [Validation(Required=false)]
            public long? DeployedReplica { get; set; }

            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APMtest</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Instance expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4792752000000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apm-cn-i7m2fuae****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public long? NodeAmount { get; set; }

            /// <summary>
            /// <para>Associated Elasticsearch instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-i7m2fsfhc001x****</para>
            /// </summary>
            [NameInMap("outputES")]
            [Validation(Required=false)]
            public string OutputES { get; set; }

            /// <summary>
            /// <para>Username of the associated Elasticsearch instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elastic</para>
            /// </summary>
            [NameInMap("outputESUserName")]
            [Validation(Required=false)]
            public string OutputESUserName { get; set; }

            /// <summary>
            /// <para>User account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>133071096032****</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Payment method, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><para>postpaid: Pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para>prepaid: Subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>Region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Replica count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>Specification, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><para>C1M2 (1 core, 2 GB)</para>
            /// </description></item>
            /// <item><description><para>C2M4 (2 cores, 4 GB)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C1M2</para>
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// <para>Lifecycle status, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><para>CREATING: Creating.</para>
            /// </description></item>
            /// <item><description><para>ACTIVATING: Activating.</para>
            /// </description></item>
            /// <item><description><para>ACTIVE: Active.</para>
            /// </description></item>
            /// <item><description><para>INACTIVE: Frozen.</para>
            /// </description></item>
            /// <item><description><para>INVALID: Invalid.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.10.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1530vdhqkamm9s0****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Availability zone where the switch is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <para>Switch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1j1mql6r9g5vfb4****</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

    }

}
