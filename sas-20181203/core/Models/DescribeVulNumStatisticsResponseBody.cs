// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulNumStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of application vulnerabilities that are detected on the asset by using the web scanner.
        /// </summary>
        [NameInMap("AppCnt")]
        [Validation(Required=false)]
        public int? AppCnt { get; set; }

        /// <summary>
        /// The number of application vulnerabilities that are detected on the asset by using the web scanner.
        /// </summary>
        [NameInMap("AppNum")]
        [Validation(Required=false)]
        public int? AppNum { get; set; }

        /// <summary>
        /// The number of Web-CMS vulnerabilities that are handled.
        /// </summary>
        [NameInMap("CmsDealedTotalNum")]
        [Validation(Required=false)]
        public int? CmsDealedTotalNum { get; set; }

        /// <summary>
        /// The number of Web-CMS vulnerabilities that are detected on the asset.
        /// </summary>
        [NameInMap("CmsNum")]
        [Validation(Required=false)]
        public int? CmsNum { get; set; }

        /// <summary>
        /// The number of Linux software vulnerabilities that are detected on the asset.
        /// </summary>
        [NameInMap("CveNum")]
        [Validation(Required=false)]
        public int? CveNum { get; set; }

        /// <summary>
        /// The number of urgent vulnerabilities that are detected on the asset.
        /// </summary>
        [NameInMap("EmgNum")]
        [Validation(Required=false)]
        public int? EmgNum { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of middleware vulnerabilities that are detected on the asset.
        /// </summary>
        [NameInMap("ScaNum")]
        [Validation(Required=false)]
        public int? ScaNum { get; set; }

        /// <summary>
        /// The number of Windows system vulnerabilities that are detected on the asset.
        /// </summary>
        [NameInMap("SysNum")]
        [Validation(Required=false)]
        public int? SysNum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the high priority.
        /// </summary>
        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that are handled.
        /// </summary>
        [NameInMap("VulDealedTotalNum")]
        [Validation(Required=false)]
        public int? VulDealedTotalNum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the medium priority.
        /// </summary>
        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the low priority.
        /// </summary>
        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

    }

}
