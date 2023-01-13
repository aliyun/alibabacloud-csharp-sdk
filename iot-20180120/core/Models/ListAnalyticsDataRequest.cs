// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListAnalyticsDataRequest : TeaModel {
        [NameInMap("ApiPath")]
        [Validation(Required=true)]
        public string ApiPath { get; set; }

        [NameInMap("Condition")]
        [Validation(Required=false)]
        public List<ListAnalyticsDataRequestCondition> Condition { get; set; }
        public class ListAnalyticsDataRequestCondition : TeaModel {
            [NameInMap("BetweenEnd")]
            [Validation(Required=false)]
            public string BetweenEnd { get; set; }

            [NameInMap("BetweenStart")]
            [Validation(Required=false)]
            public string BetweenStart { get; set; }

            [NameInMap("FieldName")]
            [Validation(Required=true)]
            public string FieldName { get; set; }

            [NameInMap("Operate")]
            [Validation(Required=true)]
            public string Operate { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=true)]
        public string IotInstanceId { get; set; }

        [NameInMap("IsoId")]
        [Validation(Required=false)]
        public string IsoId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
