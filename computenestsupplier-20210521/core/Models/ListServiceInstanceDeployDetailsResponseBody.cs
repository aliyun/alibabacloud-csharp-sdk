// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceDeployDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The deployment details of the service instance.</para>
        /// </summary>
        [NameInMap("DeployDetails")]
        [Validation(Required=false)]
        public List<ListServiceInstanceDeployDetailsResponseBodyDeployDetails> DeployDetails { get; set; }
        public class ListServiceInstanceDeployDetailsResponseBodyDeployDetails : TeaModel {
            /// <summary>
            /// <para>The number of rows in the aggregate data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The time when the entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10T01:58:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The aggregation period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public string Cycle { get; set; }

            /// <summary>
            /// <para>Indicates whether the deployment was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("DeploySucceeded")]
            [Validation(Required=false)]
            public string DeploySucceeded { get; set; }

            /// <summary>
            /// <para>The error code returned when the deployment failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StackValidationFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{code: StackValidationFailed, message: \&quot;Failed to continue create ROS stack 89e724e2-84e6-4517-a372-30a545ab4145: Resource [LinuxInstanceRunCommand]: i-wz91nfbh1fxtmfb0try4 are not running. Command invocation only support running instances. ErrorCode: StackValidationFailed\&quot;, requestId: null}</para>
            /// </summary>
            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// <para>The type of the error that occurred when the deployment failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValidationError</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-c751ed91f2074af39779</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-273e8cee11d349e1803c</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The Chinese name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试服务</para>
            /// </summary>
            [NameInMap("ServiceNameChn")]
            [Validation(Required=false)]
            public string ServiceNameChn { get; set; }

            /// <summary>
            /// <para>The English name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Service</para>
            /// </summary>
            [NameInMap("ServiceNameEng")]
            [Validation(Required=false)]
            public string ServiceNameEng { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>managed: The service is hosted in the service provider\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>operation: The service is an Alibaba Cloud Managed Service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The service version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723946641994</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1591457835436382</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAW8kZY+u1sYOaYf5JmgmDQQ=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0036D82E-0624-5B37-B797-C460F4B02026</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
