// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryInstancesInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryInstancesInfoResponseBodyData> Data { get; set; }
        public class QueryInstancesInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The enabled port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8848</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-15T02:02:15Z</para>
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.55.71.x</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The IP address of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25.24.91.x</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The pod name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-xxxxx-xxxxx-reg-center-0-1</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The internal IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.66.x</para>
            /// </summary>
            [NameInMap("SingleTunnelVip")]
            [Validation(Required=false)]
            public string SingleTunnelVip { get; set; }

            /// <summary>
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            /// <summary>
            /// <para>Indicates whether all pods are distributed across multiple zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ZoneDistributed")]
            [Validation(Required=false)]
            public bool? ZoneDistributed { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, a success message is returned.</description></item>
        /// <item><description>If the request fails, the cause of the failure is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54973C90-F379-4372-9AA5-053A3F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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
