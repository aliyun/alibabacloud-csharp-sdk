// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceTDEInfoResponseBody : TeaModel {
        /// <summary>
        /// 实例的自定义密钥。
        /// 
        /// 目前仅以下地域支持BYOK（Bring Your Own Key，用户可以自行管理和拥有加密密钥）：
        /// - 华东1（杭州）
        /// - 华东2（上海）
        /// - 华北2（北京）
        /// - 华南1（深圳）
        /// - 中国（香港）
        /// - 新加坡
        /// - 马来西亚（吉隆坡）
        /// 
        /// > 支持BYOK，用户可以管理且拥有密钥，系统将返回用户的自定义密钥；不支持BYOK，用户不可管理密钥，系统将返回字符串`NoActiveBYOK`。
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// 加密算法。
        /// </summary>
        [NameInMap("EncryptorName")]
        [Validation(Required=false)]
        public string EncryptorName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 指定待授权角色的全局资源描述符ARN（Alibaba Cloud Resource Name）信息。
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// The TDE status. Valid values:
        /// 
        /// *   **enabled**
        /// *   **disabled**
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
