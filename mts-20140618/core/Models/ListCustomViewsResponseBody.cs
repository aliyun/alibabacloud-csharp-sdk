// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomViewsResponseBody : TeaModel {
        [NameInMap("CustomViews")]
        [Validation(Required=false)]
        public ListCustomViewsResponseBodyCustomViews CustomViews { get; set; }
        public class ListCustomViewsResponseBodyCustomViews : TeaModel {
            [NameInMap("CustomView")]
            [Validation(Required=false)]
            public List<ListCustomViewsResponseBodyCustomViewsCustomView> CustomView { get; set; }
            public class ListCustomViewsResponseBodyCustomViewsCustomView : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomViewId")]
                [Validation(Required=false)]
                public string CustomViewId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http://<c>127.66.**.**</c>/photo.jpeg</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

            }

        }

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
        /// <para>580e8ce3-3b80-44c5-9f3f-36ac3cc5bdd5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
