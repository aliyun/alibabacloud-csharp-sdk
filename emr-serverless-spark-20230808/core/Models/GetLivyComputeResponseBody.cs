// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetLivyComputeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 1000000 indicates a successful request. Other values indicate a failed request. Check the message parameter for the error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLivyComputeResponseBodyData Data { get; set; }
        public class GetLivyComputeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authentication method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Token</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The auto-stop configuration.</para>
            /// </summary>
            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public GetLivyComputeResponseBodyDataAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class GetLivyComputeResponseBodyDataAutoStopConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether to automatically start the gateway after it is created.</para>
                /// <list type="bullet">
                /// <item><description><para>true: Yes.</para>
                /// </description></item>
                /// <item><description><para>false: No.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The number of minutes after which the Livy Gateway is automatically stopped if it is idle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public long? IdleTimeoutMinutes { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Livy Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lc-xxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("computeId")]
            [Validation(Required=false)]
            public string ComputeId { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the Livy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cpuLimit")]
            [Validation(Required=false)]
            public string CpuLimit { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The version number of the Spark engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The status of the public endpoint switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-spark-livy-gateway-cn-hangzhou.data.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The internal endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-spark-livy-gateway-cn-hangzhou-internal.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("endpointInner")]
            [Validation(Required=false)]
            public string EndpointInner { get; set; }

            /// <summary>
            /// <para>The ID of the runtime environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ev-cq31c7tlhtgm9nrrlj4g</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>Indicates whether the fusion switch is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749456094000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The Livy Gateway configuration in JSON format. The following files are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>sparkDefaultsConf</para>
            /// </description></item>
            /// <item><description><para>sparkBlackListConf</para>
            /// </description></item>
            /// <item><description><para>livyConf</para>
            /// </description></item>
            /// <item><description><para>livyClientConf</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;sparkDefaultsConf&quot;: &quot;spark.driver.cores     1\nspark.driver.memory    4g\nspark.executor.cores   1\nspark.executor.memory  4g\n&quot;,
            ///   &quot;sparkBlackListConf&quot;: &quot;spark.driver.cores\nspark.driver.memory&quot;,
            ///   &quot;livyConf&quot;: &quot;livy.server.session.timeout  1h\n&quot;,
            ///   &quot;livyClientConf&quot;: &quot;livy.rsc.sql.num-rows  1000\n&quot;
            /// }</para>
            /// </summary>
            [NameInMap("livyServerConf")]
            [Validation(Required=false)]
            public string LivyServerConf { get; set; }

            /// <summary>
            /// <para>The Livy version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8.0</para>
            /// </summary>
            [NameInMap("livyVersion")]
            [Validation(Required=false)]
            public string LivyVersion { get; set; }

            /// <summary>
            /// <para>The memory size of the Livy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4Gi</para>
            /// </summary>
            [NameInMap("memoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the network connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("networkName")]
            [Validation(Required=false)]
            public string NetworkName { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("ramUserId")]
            [Validation(Required=false)]
            public string RamUserId { get; set; }

            /// <summary>
            /// <para>The version number of the Spark engine. This parameter is deprecated. Use displayReleaseVersion instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12, Java Runtime)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749456094000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The running status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
