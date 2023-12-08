// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckTypesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCheckTypesResponseBodyData> Data { get; set; }
        public class ListCheckTypesResponseBodyData : TeaModel {
            [NameInMap("CheckDetails")]
            [Validation(Required=false)]
            public List<ListCheckTypesResponseBodyDataCheckDetails> CheckDetails { get; set; }
            public class ListCheckTypesResponseBodyDataCheckDetails : TeaModel {
                [NameInMap("AffiliatedRiskTypes")]
                [Validation(Required=false)]
                public List<string> AffiliatedRiskTypes { get; set; }

                [NameInMap("AffiliatedRisks")]
                [Validation(Required=false)]
                public List<string> AffiliatedRisks { get; set; }

                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public string CheckItem { get; set; }

            }

            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            [NameInMap("CheckTypeDisName")]
            [Validation(Required=false)]
            public string CheckTypeDisName { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
