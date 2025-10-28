// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sAppPrecheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetK8sAppPrecheckResultResponseBodyData Data { get; set; }
        public class GetK8sAppPrecheckResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The precheck result for the application change.</para>
            /// </summary>
            [NameInMap("JobResults")]
            [Validation(Required=false)]
            public List<GetK8sAppPrecheckResultResponseBodyDataJobResults> JobResults { get; set; }
            public class GetK8sAppPrecheckResultResponseBodyDataJobResults : TeaModel {
                /// <summary>
                /// <para>Specifies whether the precheck of the item was interrupted:</para>
                /// <list type="bullet">
                /// <item><description>true: The precheck of the item was interrupted.</description></item>
                /// <item><description>false: The precheck of the item was not interrupted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interrupted")]
                [Validation(Required=false)]
                public bool? Interrupted { get; set; }

                /// <summary>
                /// <para>The name of the precheck item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cluster Health Check</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the precheck item passed the precheck:</para>
                /// <list type="bullet">
                /// <item><description>true: The precheck item passed the precheck.</description></item>
                /// <item><description>false: The precheck item failed the precheck.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public bool? Pass { get; set; }

                /// <summary>
                /// <para>The reason why the precheck item failed the precheck or the precheck of the item was interrupted. This parameter is left empty when the application passed the precheck.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The Kubernetes cluster is disconnected from the EDAS control plane.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The reason why the application failed the precheck. This parameter is left empty when the application passed the precheck.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The Kubernetes cluster is disconnected from the EDAS control plane.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The precheck state for the application change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>checking: The application is being prechecked.</description></item>
            /// <item><description>pass: The application passed the precheck.</description></item>
            /// <item><description>failed: The application failed the precheck.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>checking</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B909AB1F-3763-4963-B1CE-0BDFA192****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
