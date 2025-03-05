// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceDeployDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the service instance deployment.</para>
        /// </summary>
        [NameInMap("DeployDetails")]
        [Validation(Required=false)]
        public List<ListServiceInstanceDeployDetailsResponseBodyDeployDetails> DeployDetails { get; set; }
        public class ListServiceInstanceDeployDetailsResponseBodyDeployDetails : TeaModel {
            /// <summary>
            /// <para>The total number of entries that meet the specified conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The time when the service instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10T01:58:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The period over which data is aggregated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public string Cycle { get; set; }

            /// <summary>
            /// <para>The indicates whether the deployment was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("DeploySucceeded")]
            [Validation(Required=false)]
            public string DeploySucceeded { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StackValidationFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{code: StackValidationFailed, message: \&quot;Failed to continue create ROS stack 89e724e2-84e6-4517-a372-30a545ab4145: Resource [LinuxInstanceRunCommand]: i-wz91nfbh1fxtmfb0try4 are not running. Command invocation only support running instances. ErrorCode: StackValidationFailed\&quot;, requestId: null}</para>
            /// </summary>
            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// <para>The type of error that caused the deployment to fail.</para>
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
            /// <para>The name of the service in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试服务(Test Service)</para>
            /// </summary>
            [NameInMap("ServiceNameChn")]
            [Validation(Required=false)]
            public string ServiceNameChn { get; set; }

            /// <summary>
            /// <para>The name of the service in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Service</para>
            /// </summary>
            [NameInMap("ServiceNameEng")]
            [Validation(Required=false)]
            public string ServiceNameEng { get; set; }

            /// <summary>
            /// <para>The type of service. </para>
            /// <para>Possible values:</para>
            /// <list type="bullet">
            /// <item><description>private: Deployed under the user\&quot;s account.</description></item>
            /// <item><description>managed: Hosted under the service provider\&quot;s account.</description></item>
            /// <item><description>operation: Managed operation service.</description></item>
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
            /// <para>The timestamp when the response is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723946641994</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The aliuid of user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1591457835436382</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
