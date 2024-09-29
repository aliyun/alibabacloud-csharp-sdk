// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCloudClusterAllUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>An array object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCloudClusterAllUrlResponseBodyData> Data { get; set; }
        public class GetCloudClusterAllUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The identifier of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amp</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The URLs for remote read and write. The value is a JSON string.</para>
            /// </summary>
            [NameInMap("RemoteUrl")]
            [Validation(Required=false)]
            public GetCloudClusterAllUrlResponseBodyDataRemoteUrl RemoteUrl { get; set; }
            public class GetCloudClusterAllUrlResponseBodyDataRemoteUrl : TeaModel {
                /// <summary>
                /// <para>Indicates whether authentication is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthToken")]
                [Validation(Required=false)]
                public bool? AuthToken { get; set; }

                /// <summary>
                /// <para>The internal URL for Grafana.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("GrafanaUrl")]
                [Validation(Required=false)]
                public string GrafanaUrl { get; set; }

                /// <summary>
                /// <para>The public URL for Grafana.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("InternetGrafanaUrl")]
                [Validation(Required=false)]
                public string InternetGrafanaUrl { get; set; }

                /// <summary>
                /// <para>The public URL for Pushgateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("InternetPushGatewayUrl")]
                [Validation(Required=false)]
                public string InternetPushGatewayUrl { get; set; }

                /// <summary>
                /// <para>The public URL for remote read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("InternetRemoteReadUrl")]
                [Validation(Required=false)]
                public string InternetRemoteReadUrl { get; set; }

                /// <summary>
                /// <para>The public URL for remote write.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("InternetRemoteWriteUrl")]
                [Validation(Required=false)]
                public string InternetRemoteWriteUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for Pushgateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("PushGatewayUrl")]
                [Validation(Required=false)]
                public string PushGatewayUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for remote read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("RemoteReadUrl")]
                [Validation(Required=false)]
                public string RemoteReadUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for remote write.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX">http://cn-hangzhou-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/XXXXXXXXXXXXXXXXX</a>&quot;</para>
                /// </summary>
                [NameInMap("RemoteWriteUrl")]
                [Validation(Required=false)]
                public string RemoteWriteUrl { get; set; }

                /// <summary>
                /// <para>The token value used for authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;eyJhbGciOiJIUzI1NiJ9.DKEIFJSL.KYK6uOtNVxTVHXJbH5MNqlsAuUtKzNlUvmAIiKc-QXw&quot;</para>
                /// </summary>
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>99A663CB-8D7B-4B0D-A006-03C8EE38E7BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
