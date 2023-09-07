// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetAdvertisingForE2ResponseBody : TeaModel {
        /// <summary>
        /// errorCode
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public GetAdvertisingForE2ResponseBodyHeader Header { get; set; }
        public class GetAdvertisingForE2ResponseBodyHeader : TeaModel {
            /// <summary>
            /// costTime
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            /// <summary>
            /// innerErrorCode
            /// </summary>
            [NameInMap("InnerErrorCode")]
            [Validation(Required=false)]
            public string InnerErrorCode { get; set; }

            /// <summary>
            /// innerErrorMsg
            /// </summary>
            [NameInMap("InnerErrorMsg")]
            [Validation(Required=false)]
            public string InnerErrorMsg { get; set; }

            /// <summary>
            /// rpcId
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// traceId
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAdvertisingForE2ResponseBodyResult Result { get; set; }
        public class GetAdvertisingForE2ResponseBodyResult : TeaModel {
            [NameInMap("ImgUrl")]
            [Validation(Required=false)]
            public string ImgUrl { get; set; }

            [NameInMap("TargetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
