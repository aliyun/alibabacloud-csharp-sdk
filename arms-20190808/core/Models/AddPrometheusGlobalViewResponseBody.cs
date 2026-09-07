// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AddPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Info-level information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{regionId: 实例所属region, globalViewClusterId: 实例Id, failedInstances: 数据源JSON list中，添加失败的单个JSON的list}</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public AddPrometheusGlobalViewResponseBodyDataInfo Info { get; set; }
            public class AddPrometheusGlobalViewResponseBodyDataInfo : TeaModel {
                /// <summary>
                /// <para>The list of instances that failed to be added.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;sourceName&quot;: &quot;数据源名称- ArmsPrometheus&quot;,&quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,&quot;userId&quot;:&quot;UserID&quot;,&quot;clusterId&quot;:&quot;ClusterId&quot;,}]</para>
                /// </summary>
                [NameInMap("FailedInstances")]
                [Validation(Required=false)]
                public string FailedInstances { get; set; }

                /// <summary>
                /// <para>The aggregation instance ID.</para>
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
            /// <para>The additional description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>Indicates whether the query was successful.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Successful.</description></item>
            /// <item><description><c>false</c>: Failed.</description></item>
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
        /// <para>The message returned for the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
