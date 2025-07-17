// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddAliClusterIdsToPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The HTTP 200 status code indicates a successful request, while others indicate error conditions.</para>
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
        public AddAliClusterIdsToPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AddAliClusterIdsToPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Info-level information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{regionId: the region where the aggregation instance resides. globalViewClusterId: the ID of the aggregation instance. failedClusterIds: the ID of the cluster that failed to be added. A cluster may fail to be added because the specified cluster ID is invalid or the cluster is added across continents.}</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public string Info { get; set; }

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
            /// <para>Indicates whether the request was successful.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The request was successful.</description></item>
            /// <item><description><c>false</c>: The request failed.</description></item>
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
        /// <para>The returned message.</para>
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
        /// <para>F7781D4A-2818-41E7-B7BB-79D809E9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
