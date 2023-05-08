// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// An array that consists of the information about the assets.
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to enable paged query. Default value: **true**. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// The number of assets on which high-risk vulnerabilities are detected.
        /// </summary>
        [NameInMap("NoPage")]
        [Validation(Required=false)]
        public bool? NoPage { get; set; }

        /// <summary>
        /// The type of the server group. Valid values:
        /// 
        /// *   **0**: the default group
        /// *   **1**: other group
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SaleVersionCheckCode")]
        [Validation(Required=false)]
        public string SaleVersionCheckCode { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

        /// <summary>
        /// The name of the group to which the assets belong. Fuzzy search is supported.
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public string Vendors { get; set; }

    }

}
