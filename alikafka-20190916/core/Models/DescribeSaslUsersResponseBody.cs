// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeSaslUsersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaslUserList")]
        [Validation(Required=false)]
        public DescribeSaslUsersResponseBodySaslUserList SaslUserList { get; set; }
        public class DescribeSaslUsersResponseBodySaslUserList : TeaModel {
            [NameInMap("SaslUserVO")]
            [Validation(Required=false)]
            public List<DescribeSaslUsersResponseBodySaslUserListSaslUserVO> SaslUserVO { get; set; }
            public class DescribeSaslUsersResponseBodySaslUserListSaslUserVO : TeaModel {
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
