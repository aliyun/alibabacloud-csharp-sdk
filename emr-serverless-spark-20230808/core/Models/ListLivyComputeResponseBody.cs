// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListLivyComputeResponseBodyData Data { get; set; }
        public class ListLivyComputeResponseBodyData : TeaModel {
            [NameInMap("livyComputes")]
            [Validation(Required=false)]
            public List<ListLivyComputeResponseBodyDataLivyComputes> LivyComputes { get; set; }
            public class ListLivyComputeResponseBodyDataLivyComputes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>lc-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("computeId")]
                [Validation(Required=false)]
                public string ComputeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("createdBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>emr-spark-livy-gateway-cn-hangzhou.data.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>emr-spark-livy-gateway-cn-hangzhou-internal.aliyun.com/api/v1/workspace/w-xxxxxxxxx/livycompute/lc-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("endpointInner")]
                [Validation(Required=false)]
                public string EndpointInner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1749456094000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root_queue</para>
                /// </summary>
                [NameInMap("queueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1749456094000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
