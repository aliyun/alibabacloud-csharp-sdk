// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the instance.
        /// </summary>
        [NameInMap("InstanceBaseInfo")]
        [Validation(Required=false)]
        public OnsInstanceBaseInfoResponseBodyInstanceBaseInfo InstanceBaseInfo { get; set; }
        public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfo : TeaModel {
            /// <summary>
            /// The time when the instance was created. The value of this parameter is a UNIX timestamp in milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The endpoints used to access ApsaraMQ for RocketMQ over different protocols.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints Endpoints { get; set; }
            public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints : TeaModel {
                /// <summary>
                /// The private HTTP endpoint of the instance.
                /// </summary>
                [NameInMap("HttpInternalEndpoint")]
                [Validation(Required=false)]
                public string HttpInternalEndpoint { get; set; }

                /// <summary>
                /// The public HTTP endpoint of the instance.
                /// </summary>
                [NameInMap("HttpInternetEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetEndpoint { get; set; }

                /// <summary>
                /// The public HTTPS endpoint of the instance.
                /// </summary>
                [NameInMap("HttpInternetSecureEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetSecureEndpoint { get; set; }

                /// <summary>
                /// The private TCP endpoint of the instance.
                /// </summary>
                [NameInMap("TcpEndpoint")]
                [Validation(Required=false)]
                public string TcpEndpoint { get; set; }

                /// <summary>
                /// The public TCP endpoint of the instance.
                /// 
                /// *   Only instances that are deployed in the China (Chengdu), China (Qingdao), or China (Shenzhen) region can be accessed by using public TCP endpoints.
                /// 
                /// *   Before you use a public TCP endpoint, make sure that your client SDK meets the following requirements:
                /// 
                ///     *   TCP client SDK for Java: V2.0.0.Final or later For more information, see [Release notes for the SDK for Java](~~325569~~).
                ///     *   TCP client SDK for C++: V3.0.0 or later For more information, see [Release notes for the SDK for C++](~~325570~~).
                /// 
                /// *   You are charged for Internet traffic when you use a public TCP endpoint. For more information, see [Internet traffic fee](~~325571~~).
                /// </summary>
                [NameInMap("TcpInternetEndpoint")]
                [Validation(Required=false)]
                public string TcpInternetEndpoint { get; set; }

            }

            /// <summary>
            /// Indicates whether the instance uses a namespace. Valid values:
            /// 
            /// *   **true**: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.
            /// *   **false**: The instance does not use a separate namespace. The name of each resource must be globally unique within the instance and across all instances.
            /// </summary>
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// 
            /// The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   **0**: The instance is being deployed. This value is valid only for Enterprise Platinum Edition instances.
            /// *   **2**: The instance has overdue payments. This value is valid only for Standard Edition instances.
            /// *   **5**: The instance is running. This value is valid for Standard Edition instances and Enterprise Platinum Edition instances.
            /// *   **7**: The instance is being upgraded and is running. This value is valid only for Enterprise Platinum Edition instances.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }

            /// <summary>
            /// The instance type. Valid values:
            /// 
            /// *   **1**: Standard Edition instances that use the pay-as-you-go billing method.
            /// *   **2**: Enterprise Platinum Edition instances that use the subscription billing method.
            /// 
            /// For information about the editions and specifications of ApsaraMQ for RocketMQ instances, see [Instance editions](~~185261~~).
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }

            /// <summary>
            /// The maximum messaging transactions per second (TPS). Valid values: 5000, 10000, 20000, 50000, 100000, 200000, 300000, 500000, 800000, and 1000000.
            /// 
            /// You can view the details about messaging TPS on the buy page of ApsaraMQ for RocketMQ.
            /// 
            /// > This parameter is available only to the ApsaraMQ for RocketMQ Enterprise Platinum Edition instances.
            /// </summary>
            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public long? MaxTps { get; set; }

            /// <summary>
            /// The time when the Enterprise Platinum Edition instance expires.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The maximum number of topics that can be created on the instance. Valid values: 25, 50, 100, 300, and 500.
            /// 
            /// > This parameter is available only to the ApsaraMQ for RocketMQ Enterprise Platinum Edition instances.
            /// </summary>
            [NameInMap("TopicCapacity")]
            [Validation(Required=false)]
            public int? TopicCapacity { get; set; }

            /// <summary>
            /// The commodity ID of the instance.
            /// </summary>
            [NameInMap("spInstanceId")]
            [Validation(Required=false)]
            public string SpInstanceId { get; set; }

            /// <summary>
            /// The commodity type of the instance.
            /// </summary>
            [NameInMap("spInstanceType")]
            [Validation(Required=false)]
            public int? SpInstanceType { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
