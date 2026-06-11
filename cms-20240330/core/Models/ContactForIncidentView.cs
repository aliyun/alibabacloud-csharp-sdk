// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ContactForIncidentView : TeaModel {
        /// <summary>
        /// <para>The contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;contact-123456&quot;</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>The contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;张三&quot;</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
