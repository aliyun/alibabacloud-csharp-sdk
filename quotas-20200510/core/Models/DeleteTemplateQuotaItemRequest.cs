// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class DeleteTemplateQuotaItemRequest : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the quota template. For more information about how to obtain the quota template ID, see <a href="https://help.aliyun.com/document_detail/450403.html">ListQuotaApplicationTemplates</a>.</para>
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

