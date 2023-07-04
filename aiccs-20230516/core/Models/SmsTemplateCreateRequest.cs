// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class SmsTemplateCreateRequest : TeaModel {
        /// <summary>
        /// 短信内容
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        /// <summary>
        /// 短信类型
        /// </summary>
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public long? SmsType { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
