// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Element : TeaModel {
        /// <summary>
        /// <para>The element contents.</para>
        /// </summary>
        [NameInMap("ElementContents")]
        [Validation(Required=false)]
        public List<ElementContent> ElementContents { get; set; }

        /// <summary>
        /// <para>The relationships between the current element and other elements.</para>
        /// </summary>
        [NameInMap("ElementRelations")]
        [Validation(Required=false)]
        public List<ElementRelation> ElementRelations { get; set; }

        /// <summary>
        /// <para>The element type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title; image; table; narrative-text</para>
        /// </summary>
        [NameInMap("ElementType")]
        [Validation(Required=false)]
        public string ElementType { get; set; }

        /// <summary>
        /// <para>The unique ID of the element.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The similarity between the current file and its extracted semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("SemanticSimilarity")]
        [Validation(Required=false)]
        public float? SemanticSimilarity { get; set; }

    }

}
