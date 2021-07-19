// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetThesaurusBySynonymForApiResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetThesaurusBySynonymForApiResponseBodyData Data { get; set; }
        public class GetThesaurusBySynonymForApiResponseBodyData : TeaModel {
            [NameInMap("ThesaurusPo")]
            [Validation(Required=false)]
            public List<GetThesaurusBySynonymForApiResponseBodyDataThesaurusPo> ThesaurusPo { get; set; }
            public class GetThesaurusBySynonymForApiResponseBodyDataThesaurusPo : TeaModel {
                public string Business { get; set; }
                public long? Id { get; set; }
                public GetThesaurusBySynonymForApiResponseBodyDataThesaurusPoSynonymList SynonymList { get; set; }
                public class GetThesaurusBySynonymForApiResponseBodyDataThesaurusPoSynonymList : TeaModel {
                    [NameInMap("SynonymList")]
                    [Validation(Required=false)]
                    public List<string> SynonymList { get; set; }

                }
            }
        };

    }

}
