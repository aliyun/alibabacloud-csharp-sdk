// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class DeleteTemplateQuotaItemRequest : TeaModel {
        /// <summary>
        /// The ID of the quota template.
        /// 
        /// You can call the [ListQuotaApplicationTemplates](https://help.aliyun.com/document_detail/450403.html) operation to obtain the ID of a quota template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
