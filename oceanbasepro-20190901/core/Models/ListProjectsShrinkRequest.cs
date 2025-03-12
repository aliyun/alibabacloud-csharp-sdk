// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectsShrinkRequest : TeaModel {
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        [NameInMap("NeedRelatedInfo")]
        [Validation(Required=false)]
        public bool? NeedRelatedInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>descend</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>np_4w****</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SinkEndpointTypes")]
        [Validation(Required=false)]
        public string SinkEndpointTypesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SourceEndpointTypes")]
        [Validation(Required=false)]
        public string SourceEndpointTypesShrink { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string StatusShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MIGRATION</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VisibleSubProject")]
        [Validation(Required=false)]
        public bool? VisibleSubProject { get; set; }

    }

}
