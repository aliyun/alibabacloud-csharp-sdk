// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventQuaraFilesRequest : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the request source. Set the value to **sas**.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("GroupingId")]
        [Validation(Required=false)]
        public long? GroupingId { get; set; }

        /// <summary>
        /// The unique ID of the quarantined file.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the server group to which the server belongs. The quarantined file is located on the server.
        /// </summary>
        [NameInMap("QuaraTag")]
        [Validation(Required=false)]
        public string QuaraTag { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
