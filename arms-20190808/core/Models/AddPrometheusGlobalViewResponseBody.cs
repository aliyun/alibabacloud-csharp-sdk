// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>状态码。说明 200表示成功。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the array object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AddPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Info-level information.</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public AddPrometheusGlobalViewResponseBodyDataInfo Info { get; set; }
            public class AddPrometheusGlobalViewResponseBodyDataInfo : TeaModel {
                /// <summary>
                /// <para>The list of instances that failed to be added.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;sourceName&quot;: &quot;Data source name- ArmsPrometheus&quot;,&quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,&quot;userId&quot;:&quot;UserID&quot;,&quot;clusterId&quot;:&quot;ClusterId&quot;,}]</para>
                /// </summary>
                [NameInMap("FailedInstances")]
                [Validation(Required=false)]
                public string FailedInstances { get; set; }

                /// <summary>
                /// <para>The ID of the global aggregation instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global-v2-cn-1483223059272121-jmjjfznz</para>
                /// </summary>
                [NameInMap("GlobalViewClusterId")]
                [Validation(Required=false)]
                public string GlobalViewClusterId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c></description></item>
            /// <item><description><c>false</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>返回结果的提示信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
