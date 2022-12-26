// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulNumStatisticsResponseBody : TeaModel {
        [NameInMap("AppCnt")]
        [Validation(Required=false)]
        public int? AppCnt { get; set; }

        [NameInMap("AppNum")]
        [Validation(Required=false)]
        public int? AppNum { get; set; }

        [NameInMap("CmsDealedTotalNum")]
        [Validation(Required=false)]
        public int? CmsDealedTotalNum { get; set; }

        [NameInMap("CmsNum")]
        [Validation(Required=false)]
        public int? CmsNum { get; set; }

        [NameInMap("CveNum")]
        [Validation(Required=false)]
        public int? CveNum { get; set; }

        [NameInMap("EmgNum")]
        [Validation(Required=false)]
        public int? EmgNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScaNum")]
        [Validation(Required=false)]
        public int? ScaNum { get; set; }

        [NameInMap("SysNum")]
        [Validation(Required=false)]
        public int? SysNum { get; set; }

        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        [NameInMap("VulDealedTotalNum")]
        [Validation(Required=false)]
        public int? VulDealedTotalNum { get; set; }

        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

    }

}
