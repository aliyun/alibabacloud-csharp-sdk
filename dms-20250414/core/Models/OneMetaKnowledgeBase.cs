// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaKnowledgeBase : TeaModel {
        /// <summary>
        /// <para>The creator of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20464374909***</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order knowledgebase</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vehicle</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Additional information about the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;keywords&quot;:&quot;sales,vehicle brand&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The time when the knowledge base was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-14 11:30:00</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the knowledge base was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-14 11:30:39</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The UUID of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_kb</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The state of the knowledge base. Valid values include 0 (No data) and 1 (Available).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The tag of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4phsj52f81ymlm***</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
