// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteIndexDocumentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of file IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

    }

}
