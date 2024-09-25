// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMonitorResponseBodyData> Data { get; set; }
        public class QueryMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The prefix of the name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-xxxx-xxxxxx</para>
            /// </summary>
            [NameInMap("clusterNamePrefix")]
            [Validation(Required=false)]
            public string ClusterNamePrefix { get; set; }

            /// <summary>
            /// <para>The name of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-xxxxxx-xxxxxx-reg-center-0-0</para>
            /// </summary>
            [NameInMap("podName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// <para>The details of the data.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request was successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADDD8AB7-8D1C-4697-A83E-410D2607****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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

}
