// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserRestrictedURLsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>big-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupSetId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

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

    }

}
