// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListAuthenticatorsResponseBody : TeaModel {
        [NameInMap("Authenticator")]
        [Validation(Required=false)]
        public List<ListAuthenticatorsResponseBodyAuthenticator> Authenticator { get; set; }
        public class ListAuthenticatorsResponseBodyAuthenticator : TeaModel {
            /// <summary>
            /// 应用ID
            /// </summary>
            [NameInMap("ApplicationExternalId")]
            [Validation(Required=false)]
            public string ApplicationExternalId { get; set; }

            /// <summary>
            /// 身份认证对应的认证器名称
            /// </summary>
            [NameInMap("AuthenticatorName")]
            [Validation(Required=false)]
            public string AuthenticatorName { get; set; }

            /// <summary>
            /// 认证器uuid
            /// </summary>
            [NameInMap("AuthenticatorUuid")]
            [Validation(Required=false)]
            public string AuthenticatorUuid { get; set; }

            /// <summary>
            /// 身份认证ID
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// 最后验证时间，如果新注册则为注册时间
            /// </summary>
            [NameInMap("LastVerifyTime")]
            [Validation(Required=false)]
            public long? LastVerifyTime { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            /// <summary>
            /// 认证器类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 读取到的位置
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页记录数量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 查询结果数据总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
