// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// 模板内容，请注意控制总字数在70个字以内，超出部分按长短信收费，按67个字为单位记一条短信，营销短信必须在结尾添加“回T退订”。
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 申请说明。
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 签名名称，同时只能指定签名名称或签名Id其中之一。
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// 签名Id，可通过ListSignatures获取审核状态为已通过的签名列表，获取签名Id。
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 模板类型。
        /// - 0 : 验证码。
        /// - 1 : 短信通知。
        /// - 2 : 推广短信。
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
