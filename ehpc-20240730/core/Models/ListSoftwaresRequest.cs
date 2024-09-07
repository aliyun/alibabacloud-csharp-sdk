// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSoftwaresRequest : TeaModel {
        /// <summary>
        /// The application category.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The software name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operating system (OS) information.
        /// </summary>
        [NameInMap("OsInfos")]
        [Validation(Required=false)]
        public List<ListSoftwaresRequestOsInfos> OsInfos { get; set; }
        public class ListSoftwaresRequestOsInfos : TeaModel {
            /// <summary>
            /// The OS architecture. Valid values:
            /// 
            /// *   x86_64
            /// *   arm64
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// The image tag.
            /// </summary>
            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
