// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentNoteStruct : TeaModel {
        /// <summary>
        /// <para>The content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>已联系运维团队，正在排查问题。</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>The record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>note-001</para>
        /// </summary>
        [NameInMap("noteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>The operator.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public IncidentNoteStructOperator Operator { get; set; }
        public class IncidentNoteStructOperator : TeaModel {
            /// <summary>
            /// <para>The contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;mobile_phone_num\&quot;:\&quot;153xxxx8040\&quot;,\&quot;mobile_country_code\&quot;:\&quot;86\&quot;,\&quot;email\&quot;:\&quot;<a href="mailto:flightxxg@dida.com">flightxxg@dida.com</a>\&quot;}</para>
            /// </summary>
            [NameInMap("contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            /// <summary>
            /// <para>The contact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-12345</para>
            /// </summary>
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4123456</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
