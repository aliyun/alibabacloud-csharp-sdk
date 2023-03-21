// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineItemListRequest : TeaModel {
        /// <summary>
        /// The key of the baseline type.
        /// </summary>
        [NameInMap("BaselineClassKey")]
        [Validation(Required=false)]
        public string BaselineClassKey { get; set; }

        /// <summary>
        /// The key of the baseline name.
        /// </summary>
        [NameInMap("BaselineNameKey")]
        [Validation(Required=false)]
        public string BaselineNameKey { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The UUID of the image.
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The types of the assets that are scanned.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// The status of the baseline risk item. Valid values:
        /// 
        /// *   **0**: unfixed
        /// *   **1**: fixed
        /// *   **2**: pending verification
        /// *   **3**: fixing failed
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The UUIDs of images.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
