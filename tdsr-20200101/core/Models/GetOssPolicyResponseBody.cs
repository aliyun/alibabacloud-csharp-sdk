// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetOssPolicyResponseBody : TeaModel {
        /// <summary>
        /// 请求ID，与入参requestId对应
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// accessId
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// 授权
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// 授权路径
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// 上传地址
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// 授权失效时间(s)
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// 上传回调
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

    }

}
