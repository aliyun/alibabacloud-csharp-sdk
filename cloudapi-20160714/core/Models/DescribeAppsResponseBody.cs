// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        /// <summary>
        /// The returned app information. It is an array consisting of AppItem data.
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppsResponseBodyApps Apps { get; set; }
        public class DescribeAppsResponseBodyApps : TeaModel {
            [NameInMap("AppItem")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppsAppItem> AppItem { get; set; }
            public class DescribeAppsResponseBodyAppsAppItem : TeaModel {
                /// <summary>
                /// The ID of the app.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// The name of the app.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The description of the app.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
