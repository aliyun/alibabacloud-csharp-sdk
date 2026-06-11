// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpsertDocumentChunksRequest : TeaModel {
        /// <summary>
        /// <para>A list of document chunks to upsert.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;Id&quot;: &quot;2e12aeb5-52cd-4834-bcd8-<b><b>&quot;,
        ///     &quot;Content&quot;: &quot;test1&quot;
        ///   },
        ///   {
        ///     &quot;Id&quot;: &quot;2fdnwefi5-dsad-4t35-bcd8-</b></b>&quot;,
        ///     &quot;Content&quot;: &quot;test2&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("Chunks")]
        [Validation(Required=false)]
        public string Chunks { get; set; }

        /// <summary>
        /// <para>The name of the document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>The unique identifier for the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

    }

}
