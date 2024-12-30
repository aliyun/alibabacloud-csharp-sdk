// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetClusterQueueInfoByEnvResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetClusterQueueInfoByEnvResponseBodyData> Data { get; set; }
        public class GetClusterQueueInfoByEnvResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{  &quot;creator&quot;: &quot;<a href="mailto:new_datasource@test.aliyunid.com">new_datasource@test.aliyunid.com</a>&quot;,  &quot;modifier&quot;: &quot;<a href="mailto:new_datasource@test.aliyunid.com">new_datasource@test.aliyunid.com</a>&quot; }</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public string Annotations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>61187014-a3ba-4cdd-8609-1f0aa3df4a3d</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-31 10:29:17</para>
            /// </summary>
            [NameInMap("CreateAt")]
            [Validation(Required=false)]
            public string CreateAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx-registry-vpc.cn-shanghai.cr.aliyuncs.com/xxxx/flink:1.15.4-scala_2.12</para>
            /// </summary>
            [NameInMap("FlinkImageRegistry")]
            [Validation(Required=false)]
            public string FlinkImageRegistry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx-registry-vpc.cn-shanghai.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("FlinkImageRepository")]
            [Validation(Required=false)]
            public string FlinkImageRepository { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.15.4</para>
            /// </summary>
            [NameInMap("FlinkImageTag")]
            [Validation(Required=false)]
            public string FlinkImageTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.15</para>
            /// </summary>
            [NameInMap("FlinkVersion")]
            [Validation(Required=false)]
            public string FlinkVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cdh</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxVcore")]
            [Validation(Required=false)]
            public string MaxVcore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-31 10:29:17</para>
            /// </summary>
            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataphinv45prod</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default-queue</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceVersion")]
            [Validation(Required=false)]
            public string ResourceVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\n  \&quot;kind\&quot; : \&quot;kubernetes\&quot;,\n  \&quot;kubernetes\{&quot;namespace&quot; : &quot;n1730341728989z7&quot;,    &quot;clusterName&quot; : &quot;a51578bdcce145&quot;  },  &quot;state&quot; : &quot;ONLINE&quot;}</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PREJOB</para>
            /// </summary>
            [NameInMap("VvpClusterType")]
            [Validation(Required=false)]
            public string VvpClusterType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
