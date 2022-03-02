// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// 人群Id，用于关联人群。
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 外部拓展字段。
        /// </summary>
        [NameInMap("OutIds")]
        [Validation(Required=false)]
        public List<string> OutIds { get; set; }

        /// <summary>
        /// 手机号，每个手机号对应一个模板变量、上行拓展码和外部拓展字段。
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// 发送计划Id，用于关联发送计划。
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 签名名称。
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// 签名Id，同时只能指定签名名称或签名Id其中之一。
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 短信上行拓展码。
        /// </summary>
        [NameInMap("SmsUpExtendCodes")]
        [Validation(Required=false)]
        public List<string> SmsUpExtendCodes { get; set; }

        /// <summary>
        /// 模板Code。
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板Id，同时只能指定模板Code或模板Id其中之一。
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 短信模板变量对应的实际值，JSON格式。支持传入多个参数，示例：{"name":"张三","number":"15038****76"}。
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public List<string> TemplateParams { get; set; }

    }

}
