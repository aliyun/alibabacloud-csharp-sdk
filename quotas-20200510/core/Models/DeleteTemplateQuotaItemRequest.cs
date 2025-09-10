// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class DeleteTemplateQuotaItemRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota template.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/450403.html">ListQuotaApplicationTemplates</a> operation to obtain the ID of a quota template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
