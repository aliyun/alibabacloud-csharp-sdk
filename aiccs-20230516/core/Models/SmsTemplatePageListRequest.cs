// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class SmsTemplatePageListRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// 模板状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
