// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Predicate : TeaModel {
        /// <summary>
        /// <para>The list of child nodes.</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<Predicate> Children { get; set; }

        /// <summary>
        /// <para>The assertion function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// <para>The assertion type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPRESSION</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The list of literal values.</para>
        /// </summary>
        [NameInMap("literals")]
        [Validation(Required=false)]
        public List<object> Literals { get; set; }

        /// <summary>
        /// <para>The transform rule.</para>
        /// </summary>
        [NameInMap("transform")]
        [Validation(Required=false)]
        public Transform Transform { get; set; }

    }

}
