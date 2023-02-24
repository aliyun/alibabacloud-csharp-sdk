// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoRemainResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretRemainDTO")]
        [Validation(Required=false)]
        public QuerySecretNoRemainResponseBodySecretRemainDTO SecretRemainDTO { get; set; }
        public class QuerySecretNoRemainResponseBodySecretRemainDTO : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("RemainDTOList")]
            [Validation(Required=false)]
            public QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList RemainDTOList { get; set; }
            public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList : TeaModel {
                [NameInMap("remainDTO")]
                [Validation(Required=false)]
                public List<QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO> RemainDTO { get; set; }
                public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO : TeaModel {
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                }

            }

        }

    }

}
