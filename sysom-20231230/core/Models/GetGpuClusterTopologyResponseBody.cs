// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values: Success, Sysom.ServerError, and Sysom.InvalidParameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fail/Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned by the operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGpuClusterTopologyResponseBodyData Data { get; set; }
        public class GetGpuClusterTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster topology data structure.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public GetGpuClusterTopologyResponseBodyDataData Data { get; set; }
            public class GetGpuClusterTopologyResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The edge data in the topology structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;edges&quot;: [
                ///         {
                ///           &quot;type&quot;: &quot;GPU&quot;,
                ///           &quot;src_id&quot;: &quot;00534a88&quot;,
                ///           &quot;dst_id&quot;: &quot;260525e9&quot;,
                ///           &quot;values&quot;: {
                ///             &quot;Exception&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;NCCL HANG&quot;,
                ///                 &quot;value&quot;: &quot;error0&quot;
                ///               }
                ///             ],
                ///             &quot;Metric&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;a&quot;,
                ///                 &quot;value&quot;: &quot;372201199012283428&quot;
                ///               }
                ///             ],
                ///             &quot;Basic&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;NCCL Version&quot;,
                ///                 &quot;value&quot;: &quot;v2.22.3&quot;
                ///               }
                ///             ]
                ///           },
                ///           &quot;style&quot;: {
                ///             &quot;lineWidth&quot;: &quot;0.01&quot;,
                ///             &quot;opacity&quot;: &quot;1&quot;,
                ///             &quot;selectedStyle&quot;: &quot;\&quot;{\\\&quot;opacity\\\&quot;: 1, \\\&quot;lineWidth\\\&quot;: 1}\&quot;&quot;,
                ///             &quot;stroke&quot;: &quot;#e94242\n&quot;
                ///           }
                ///         }
                ///       ]</para>
                /// </summary>
                [NameInMap("edges")]
                [Validation(Required=false)]
                public object Edges { get; set; }

                /// <summary>
                /// <para>The node data in the topology structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;nodes&quot;: [
                ///         {
                ///           &quot;id&quot;: &quot;i-xxxxxx&quot;,
                ///           &quot;name&quot;: &quot;i-xxxxxx&quot;,
                ///           &quot;gpu_list&quot;: [
                ///             {
                ///               &quot;id&quot;: &quot;6cc37fbc&quot;,
                ///               &quot;name&quot;: &quot;GPU0&quot;,
                ///               &quot;style&quot;: {
                ///                 &quot;fill&quot;: &quot;#e94242&quot;,
                ///                 &quot;opacity&quot;: &quot;0.1&quot;
                ///               },
                ///               &quot;values&quot;: {
                ///                 &quot;Metric&quot;: [
                ///                   {
                ///                     &quot;key&quot;: &quot;0&quot;,
                ///                     &quot;value&quot;: &quot;gpu_util(%)&quot;
                ///                   }
                ///                 ],
                ///                 &quot;Basic&quot;: [
                ///                   {
                ///                     &quot;key&quot;: &quot;1&quot;,
                ///                     &quot;value&quot;: &quot;Gpu Number&quot;
                ///                   }
                ///                 ],
                ///                 &quot;Exception&quot;: [
                ///                   {
                ///                     &quot;key&quot;: &quot;NCCL HANG&quot;,
                ///                     &quot;value&quot;: &quot;error0&quot;
                ///                   }
                ///                 ]
                ///               }
                ///             }
                ///           ],
                ///           &quot;style&quot;: {
                ///             &quot;fillOpacity&quot;: &quot;0.5&quot;,
                ///             &quot;fill&quot;: &quot;#e94242&quot;
                ///           },
                ///           &quot;values&quot;: {
                ///             &quot;Exception&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;NCCL HANG&quot;,
                ///                 &quot;value&quot;: &quot;error0&quot;
                ///               }
                ///             ],
                ///             &quot;Basic&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;podList&quot;,
                ///                 &quot;value&quot;: &quot;podname1&quot;
                ///               }
                ///             ],
                ///             &quot;Metric&quot;: [
                ///               {
                ///                 &quot;key&quot;: &quot;instance&quot;,
                ///                 &quot;value&quot;: &quot;i-xxxxxx&quot;
                ///               }
                ///             ]
                ///           }
                ///         }
                ///       ],</para>
                /// </summary>
                [NameInMap("nodes")]
                [Validation(Required=false)]
                public object Nodes { get; set; }

            }

            /// <summary>
            /// <para>The total number of GPUs returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the code is not Success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>some error msg if not success，“” if success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>return real request ID</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
