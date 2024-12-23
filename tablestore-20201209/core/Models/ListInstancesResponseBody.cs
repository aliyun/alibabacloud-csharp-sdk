// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The instance alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance-test</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-04-07T09:19:21Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of the test instance.</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The name of the instance, which is used to uniquely identify the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// <list type="bullet">
            /// <item><description>SSD: high-performance instance</description></item>
            /// <item><description>HYBRID: capacity instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("InstanceSpecification")]
            [Validation(Required=false)]
            public string InstanceSpecification { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("IsMultiAZ")]
            [Validation(Required=false)]
            public bool? IsMultiAZ { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <list type="bullet">
            /// <item><description>Subscription: subscription</description></item>
            /// <item><description>PayAsYouGo: pay as you go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxh4em5jnbcd</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ots_standard_public_cn-g4t3igqjj002</para>
            /// </summary>
            [NameInMap("SPInstanceId")]
            [Validation(Required=false)]
            public string SPInstanceId { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// <list type="bullet">
            /// <item><description>SSD: high-performance</description></item>
            /// <item><description>HYBRID: capacity</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13542356466</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The VCU quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("VCUQuota")]
            [Validation(Required=false)]
            public int? VCUQuota { get; set; }

        }

        /// <summary>
        /// <para>The token that determines the start position of the next query. If this parameter is empty, all instances that you want to query are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESCG15aC1xxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E734979F-5A44-5993-9CE5-C23103576923</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
