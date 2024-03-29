// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListOrderConsumeStatisticRecordsRequest : TeaModel {
        [NameInMap("AliOrderCode")]
        [Validation(Required=false)]
        public string AliOrderCode { get; set; }

        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("StatisticTimeMax")]
        [Validation(Required=false)]
        public string StatisticTimeMax { get; set; }

        [NameInMap("StatisticTimeMin")]
        [Validation(Required=false)]
        public string StatisticTimeMin { get; set; }

    }

}
