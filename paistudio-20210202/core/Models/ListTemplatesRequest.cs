// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListTemplatesRequest : TeaModel {
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>types</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public string List { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStudio</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-tag-12345</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-type-12345</para>
        /// </summary>
        [NameInMap("TypeId")]
        [Validation(Required=false)]
        public string TypeId { get; set; }

        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
