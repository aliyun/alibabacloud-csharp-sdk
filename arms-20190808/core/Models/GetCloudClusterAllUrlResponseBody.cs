// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCloudClusterAllUrlResponseBody : TeaModel {
        /// <summary>
        /// 状态码。200为成功，其他状态码为异常。
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// An array object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCloudClusterAllUrlResponseBodyData> Data { get; set; }
        public class GetCloudClusterAllUrlResponseBodyData : TeaModel {
            /// <summary>
            /// The identifier of the cloud service.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The URLs for remote read and write. The value is a JSON string.
            /// </summary>
            [NameInMap("RemoteUrl")]
            [Validation(Required=false)]
            public GetCloudClusterAllUrlResponseBodyDataRemoteUrl RemoteUrl { get; set; }
            public class GetCloudClusterAllUrlResponseBodyDataRemoteUrl : TeaModel {
                /// <summary>
                /// Indicates whether authentication is enabled.
                /// </summary>
                [NameInMap("AuthToken")]
                [Validation(Required=false)]
                public bool? AuthToken { get; set; }

                /// <summary>
                /// The internal URL for Grafana.
                /// </summary>
                [NameInMap("GrafanaUrl")]
                [Validation(Required=false)]
                public string GrafanaUrl { get; set; }

                /// <summary>
                /// The public URL for Grafana.
                /// </summary>
                [NameInMap("InternetGrafanaUrl")]
                [Validation(Required=false)]
                public string InternetGrafanaUrl { get; set; }

                /// <summary>
                /// The public URL for Pushgateway.
                /// </summary>
                [NameInMap("InternetPushGatewayUrl")]
                [Validation(Required=false)]
                public string InternetPushGatewayUrl { get; set; }

                /// <summary>
                /// The public URL for remote read.
                /// </summary>
                [NameInMap("InternetRemoteReadUrl")]
                [Validation(Required=false)]
                public string InternetRemoteReadUrl { get; set; }

                /// <summary>
                /// The public URL for remote write.
                /// </summary>
                [NameInMap("InternetRemoteWriteUrl")]
                [Validation(Required=false)]
                public string InternetRemoteWriteUrl { get; set; }

                /// <summary>
                /// The internal URL for Pushgateway.
                /// </summary>
                [NameInMap("PushGatewayUrl")]
                [Validation(Required=false)]
                public string PushGatewayUrl { get; set; }

                /// <summary>
                /// The internal URL for remote read.
                /// </summary>
                [NameInMap("RemoteReadUrl")]
                [Validation(Required=false)]
                public string RemoteReadUrl { get; set; }

                /// <summary>
                /// The internal URL for remote write.
                /// </summary>
                [NameInMap("RemoteWriteUrl")]
                [Validation(Required=false)]
                public string RemoteWriteUrl { get; set; }

                /// <summary>
                /// The token value used for authentication.
                /// </summary>
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

        }

        /// <summary>
        /// 详细信息。
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 操作是否成功：true：操作成功                                 false：操作失败
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
