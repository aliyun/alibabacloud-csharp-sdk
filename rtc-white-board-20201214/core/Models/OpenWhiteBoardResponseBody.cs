// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class OpenWhiteBoardResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回结果体
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public OpenWhiteBoardResponseBodyResult Result { get; set; }
        public class OpenWhiteBoardResponseBodyResult : TeaModel {
            [NameInMap("DocumentAccessInfo")]
            [Validation(Required=false)]
            public OpenWhiteBoardResponseBodyResultDocumentAccessInfo DocumentAccessInfo { get; set; }
            public class OpenWhiteBoardResponseBodyResultDocumentAccessInfo : TeaModel {
                /// <summary>
                /// 连接签名
                /// </summary>
                [NameInMap("AccessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

                /// <summary>
                /// 白板长连接地址
                /// </summary>
                [NameInMap("CollabHost")]
                [Validation(Required=false)]
                public string CollabHost { get; set; }

                /// <summary>
                /// 权限码，取值：0:无权限，1:只读，2:读写
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public long? Permission { get; set; }

                /// <summary>
                /// 用户信息
                /// </summary>
                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public OpenWhiteBoardResponseBodyResultDocumentAccessInfoUserInfo UserInfo { get; set; }
                public class OpenWhiteBoardResponseBodyResultDocumentAccessInfoUserInfo : TeaModel {
                    [NameInMap("AvatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }
                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }
                    [NameInMap("NickPinyin")]
                    [Validation(Required=false)]
                    public string NickPinyin { get; set; }
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }
                };

                /// <summary>
                /// 新协议长连接服务域名
                /// </summary>
                [NameInMap("WsDomain")]
                [Validation(Required=false)]
                public string WsDomain { get; set; }

            }
        };

    }

}
