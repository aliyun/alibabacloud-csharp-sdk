// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// The language that is used in the templates.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The keyword that is used to search for templates. This parameter is invalid if you specify a tag.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number of current page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of templates on each page. A page can contain a maximum of 100 templates. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The tag that is used to search for templates.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
