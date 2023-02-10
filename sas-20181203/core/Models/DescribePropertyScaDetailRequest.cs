// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailRequest : TeaModel {
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public long? Name { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ProcessStartedEnd")]
        [Validation(Required=false)]
        public long? ProcessStartedEnd { get; set; }

        [NameInMap("ProcessStartedStart")]
        [Validation(Required=false)]
        public long? ProcessStartedStart { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ScaName")]
        [Validation(Required=false)]
        public string ScaName { get; set; }

        [NameInMap("ScaNamePattern")]
        [Validation(Required=false)]
        public string ScaNamePattern { get; set; }

        [NameInMap("ScaVersion")]
        [Validation(Required=false)]
        public string ScaVersion { get; set; }

        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        [NameInMap("SearchInfoSub")]
        [Validation(Required=false)]
        public string SearchInfoSub { get; set; }

        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        [NameInMap("SearchItemSub")]
        [Validation(Required=false)]
        public string SearchItemSub { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
