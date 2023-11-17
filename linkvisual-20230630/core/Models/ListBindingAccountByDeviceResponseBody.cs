// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class ListBindingAccountByDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBindingAccountByDeviceResponseBodyData Data { get; set; }
        public class ListBindingAccountByDeviceResponseBodyData : TeaModel {
            [NameInMap("AccountList")]
            [Validation(Required=false)]
            public List<ListBindingAccountByDeviceResponseBodyDataAccountList> AccountList { get; set; }
            public class ListBindingAccountByDeviceResponseBodyDataAccountList : TeaModel {
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public long? BindTime { get; set; }

                [NameInMap("IdentityAlias")]
                [Validation(Required=false)]
                public string IdentityAlias { get; set; }

                [NameInMap("IdentityId")]
                [Validation(Required=false)]
                public string IdentityId { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
