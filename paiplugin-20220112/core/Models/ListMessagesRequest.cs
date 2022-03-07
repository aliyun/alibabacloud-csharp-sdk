// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessagesRequest : TeaModel {
        /// <summary>
        /// 发送日期，格式为20220101。
        /// </summary>
        [NameInMap("Datetime")]
        [Validation(Required=false)]
        public string Datetime { get; set; }

        /// <summary>
        /// 关联人群Id过滤。
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 短信Id过滤，短信Id为SendMessage成功返回的Id。
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 分页数，从1开始，默认为1。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小，默认为10。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 手机号码过滤。
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信批处理Id过滤，短信批处理Id为SendMessage成功返回的RequestId。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 关联触达计划Id过滤。
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 签名名称过滤。
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// 签名Id过滤，同时只能指定签名名称或签名Id其中之一。
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 短信发送状态过滤。
        /// - 0 : 发送中。
        /// - 1 : 发送成功。
        /// - 2 : 发送失败。
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 模板号过滤。
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板Id过滤，同时只能指定模板Code或模板Id其中之一。
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板类型过滤。
        /// - 0 : 验证码。
        /// - 1 : 短信通知。
        /// - 2 : 推广短信。
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
