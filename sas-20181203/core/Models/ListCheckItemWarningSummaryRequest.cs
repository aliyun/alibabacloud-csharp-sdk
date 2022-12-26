// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryRequest : TeaModel {
        [NameInMap("CheckItemFuzzy")]
        [Validation(Required=false)]
        public string CheckItemFuzzy { get; set; }

        [NameInMap("CheckLevel")]
        [Validation(Required=false)]
        public string CheckLevel { get; set; }

        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        [NameInMap("CheckWarningStatus")]
        [Validation(Required=false)]
        public int? CheckWarningStatus { get; set; }

        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

    }

}
