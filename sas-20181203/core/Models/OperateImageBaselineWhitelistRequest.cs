// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateImageBaselineWhitelistRequest : TeaModel {
        /// <summary>
        /// The keys of baseline check items.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineItemKeyList")]
        [Validation(Required=false)]
        public string BaselineItemKeyList { get; set; }

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
        /// The operation that you want to perform on the check items. Valid values:
        /// 
        /// *   **add**: adds the check items to the whitelist
        /// *   **del**: removes the check items from the whitelist
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The types of the assets that you want to scan.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

    }

}
