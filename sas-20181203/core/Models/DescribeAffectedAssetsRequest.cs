// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAffectedAssetsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        /// <summary>
        /// The severity. Separate multiple severities with commas (,). Valid values:
        /// 
        /// *   serious
        /// *   suspicious
        /// *   remind
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
