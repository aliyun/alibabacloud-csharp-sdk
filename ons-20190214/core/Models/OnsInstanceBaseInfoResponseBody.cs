// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instance.</para>
        /// </summary>
        [NameInMap("InstanceBaseInfo")]
        [Validation(Required=false)]
        public OnsInstanceBaseInfoResponseBodyInstanceBaseInfo InstanceBaseInfo { get; set; }
        public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfo : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. The value of this parameter is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570701259403</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The endpoints used to access ApsaraMQ for RocketMQ over different protocols.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints Endpoints { get; set; }
            public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints : TeaModel {
                /// <summary>
                /// <para>The private HTTP endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://138015630679****.mqrest.cn-chengdu-internal.aliyuncs.com">http://138015630679****.mqrest.cn-chengdu-internal.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("HttpInternalEndpoint")]
                [Validation(Required=false)]
                public string HttpInternalEndpoint { get; set; }

                /// <summary>
                /// <para>The public HTTP endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://138015630679****.mqrest.cn-chengdu.aliyuncs.com">http://138015630679****.mqrest.cn-chengdu.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("HttpInternetEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetEndpoint { get; set; }

                /// <summary>
                /// <para>The public HTTPS endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://138015630679****.mqrest.cn-chengdu.aliyuncs.com">https://138015630679****.mqrest.cn-chengdu.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("HttpInternetSecureEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetSecureEndpoint { get; set; }

                /// <summary>
                /// <para>The private TCP endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://MQ_INST_138015630679****_BAAy1Hac.cn-chengdu.mq-internal.aliyuncs.com:8080">http://MQ_INST_138015630679****_BAAy1Hac.cn-chengdu.mq-internal.aliyuncs.com:8080</a></para>
                /// </summary>
                [NameInMap("TcpEndpoint")]
                [Validation(Required=false)]
                public string TcpEndpoint { get; set; }

                /// <summary>
                /// <para>The public TCP endpoint of the instance.</para>
                /// <list type="bullet">
                /// <item><description><para>Only instances that are deployed in the China (Chengdu), China (Qingdao), or China (Shenzhen) region can be accessed by using public TCP endpoints.</para>
                /// </description></item>
                /// <item><description><para>Before you use a public TCP endpoint, make sure that your client SDK meets the following requirements:</para>
                /// <list type="bullet">
                /// <item><description>TCP client SDK for Java: V2.0.0.Final or later For more information, see <a href="https://help.aliyun.com/document_detail/325569.html">Release notes for the SDK for Java</a>.</description></item>
                /// <item><description>TCP client SDK for C++: V3.0.0 or later For more information, see <a href="https://help.aliyun.com/document_detail/325570.html">Release notes for the SDK for C++</a>.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>You are charged for Internet traffic when you use a public TCP endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/325571.html">Internet traffic fee</a>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://MQ_INST_138015630679****_BAAy1Hac.mq.cn-chengdu.aliyuncs.com:80">http://MQ_INST_138015630679****_BAAy1Hac.mq.cn-chengdu.aliyuncs.com:80</a></para>
                /// </summary>
                [NameInMap("TcpInternetEndpoint")]
                [Validation(Required=false)]
                public string TcpInternetEndpoint { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the instance uses a namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.</description></item>
            /// <item><description><b>false</b>: The instance does not use a separate namespace. The name of each resource must be globally unique within the instance and across all instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_138015630679****_BAAy1Hac</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// <para>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The instance is being deployed. This value is valid only for Enterprise Platinum Edition instances.</description></item>
            /// <item><description><b>2</b>: The instance has overdue payments. This value is valid only for Standard Edition instances.</description></item>
            /// <item><description><b>5</b>: The instance is running. This value is valid for Standard Edition instances and Enterprise Platinum Edition instances.</description></item>
            /// <item><description><b>7</b>: The instance is being upgraded and is running. This value is valid only for Enterprise Platinum Edition instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Standard Edition instances that use the pay-as-you-go billing method.</description></item>
            /// <item><description><b>2</b>: Enterprise Platinum Edition instances that use the subscription billing method.</description></item>
            /// </list>
            /// <para>For information about the editions and specifications of ApsaraMQ for RocketMQ instances, see <a href="https://help.aliyun.com/document_detail/185261.html">Instance editions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum messaging transactions per second (TPS). Valid values: 5000, 10000, 20000, 50000, 100000, 200000, 300000, 500000, 800000, and 1000000.</para>
            /// <para>You can view the details about messaging TPS on the buy page of ApsaraMQ for RocketMQ.</para>
            /// <remarks>
            /// <para>This parameter is available only to the ApsaraMQ for RocketMQ Enterprise Platinum Edition instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public long? MaxTps { get; set; }

            /// <summary>
            /// <para>The time when the Enterprise Platinum Edition instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603555200000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ons-cn-m7r1r5f****</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SupportClassic")]
            [Validation(Required=false)]
            public int? SupportClassic { get; set; }

            /// <summary>
            /// <para>The maximum number of topics that can be created on the instance. Valid values: 25, 50, 100, 300, and 500.</para>
            /// <remarks>
            /// <para>This parameter is available only to the ApsaraMQ for RocketMQ Enterprise Platinum Edition instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TopicCapacity")]
            [Validation(Required=false)]
            public int? TopicCapacity { get; set; }

            /// <summary>
            /// <para>The commodity ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ons-cn-m7r1r5f****</para>
            /// </summary>
            [NameInMap("spInstanceId")]
            [Validation(Required=false)]
            public string SpInstanceId { get; set; }

            /// <summary>
            /// <para>The commodity type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("spInstanceType")]
            [Validation(Required=false)]
            public int? SpInstanceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CC46974-65E8-4C20-AB07-D20D102E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
