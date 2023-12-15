// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppsByApiProductResponseBody : TeaModel {
        /// <summary>
        /// The information about authorized applications.
        /// </summary>
        [NameInMap("AuthorizedApps")]
        [Validation(Required=false)]
        public DescribeAppsByApiProductResponseBodyAuthorizedApps AuthorizedApps { get; set; }
        public class DescribeAppsByApiProductResponseBodyAuthorizedApps : TeaModel {
            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp> AuthorizedApp { get; set; }
            public class DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp : TeaModel {
                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The expiration time of the authorization. The time is in GMT. An empty value indicates that the authorization does not expire.
                /// </summary>
                [NameInMap("AuthValidTime")]
                [Validation(Required=false)]
                public string AuthValidTime { get; set; }

                /// <summary>
                /// The time when the authorization was created. The time is in GMT.
                /// </summary>
                [NameInMap("AuthorizedTime")]
                [Validation(Required=false)]
                public string AuthorizedTime { get; set; }

                /// <summary>
                /// The authorization description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The extended information.
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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
