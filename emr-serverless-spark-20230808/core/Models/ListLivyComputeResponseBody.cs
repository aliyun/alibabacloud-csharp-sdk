// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the request. A value of 1000000 indicates that the request is successful. Other values indicate that the request failed. For specific error details, see the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListLivyComputeResponseBodyData Data { get; set; }
        public class ListLivyComputeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of Livy gateways.</para>
            /// </summary>
            [NameInMap("livyComputes")]
            [Validation(Required=false)]
            public List<ListLivyComputeResponseBodyDataLivyComputes> LivyComputes { get; set; }
            public class ListLivyComputeResponseBodyDataLivyComputes : TeaModel {
                /// <summary>
                /// <para>The ID of the Livy gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lc-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("computeId")]
                [Validation(Required=false)]
                public string ComputeId { get; set; }

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
                /// <para>The public network connection endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>emr-spark-livy-gateway-cn-hangzhou.data.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The internal network connection endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>emr-spark-livy-gateway-cn-hangzhou-internal.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("endpointInner")]
                [Validation(Required=false)]
                public string EndpointInner { get; set; }

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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
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
