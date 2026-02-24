// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentContactStruct : TeaModel {
        /// <summary>
        /// <para>Channel list.</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public List<string> Channel { get; set; }

        /// <summary>
        /// <para>Contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>627415</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Contact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP</para>
        /// </summary>
        [NameInMap("contactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

    }

}
