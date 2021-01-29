// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeChinapassportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeChinapassportResponseBodyData Data { get; set; }
        public class RecognizeChinapassportResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }
            [NameInMap("Authority")]
            [Validation(Required=false)]
            public string Authority { get; set; }
            [NameInMap("IssuePlaceRaw")]
            [Validation(Required=false)]
            public string IssuePlaceRaw { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("LineOne")]
            [Validation(Required=false)]
            public string LineOne { get; set; }
            [NameInMap("ExpiryDate")]
            [Validation(Required=false)]
            public string ExpiryDate { get; set; }
            [NameInMap("BirthPlace")]
            [Validation(Required=false)]
            public string BirthPlace { get; set; }
            [NameInMap("PassportNo")]
            [Validation(Required=false)]
            public string PassportNo { get; set; }
            [NameInMap("BirthPlaceRaw")]
            [Validation(Required=false)]
            public string BirthPlaceRaw { get; set; }
            [NameInMap("IssueDate")]
            [Validation(Required=false)]
            public string IssueDate { get; set; }
            [NameInMap("SourceCountry")]
            [Validation(Required=false)]
            public string SourceCountry { get; set; }
            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public string BirthDate { get; set; }
            [NameInMap("NameChineseRaw")]
            [Validation(Required=false)]
            public string NameChineseRaw { get; set; }
            [NameInMap("IssuePlace")]
            [Validation(Required=false)]
            public string IssuePlace { get; set; }
            [NameInMap("NameChinese")]
            [Validation(Required=false)]
            public string NameChinese { get; set; }
            [NameInMap("LineZero")]
            [Validation(Required=false)]
            public string LineZero { get; set; }
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }
            [NameInMap("BirthDay")]
            [Validation(Required=false)]
            public string BirthDay { get; set; }
            [NameInMap("ExpiryDay")]
            [Validation(Required=false)]
            public string ExpiryDay { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }
        };

    }

}
