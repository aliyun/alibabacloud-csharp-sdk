// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetCustomerCategoryDictionaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerCategoryDictionaryResponseBodyData Data { get; set; }
        public class GetCustomerCategoryDictionaryResponseBodyData : TeaModel {
            [NameInMap("EnumConfig")]
            [Validation(Required=false)]
            public List<GetCustomerCategoryDictionaryResponseBodyDataEnumConfig> EnumConfig { get; set; }
            public class GetCustomerCategoryDictionaryResponseBodyDataEnumConfig : TeaModel {
                [NameInMap("enumName")]
                [Validation(Required=false)]
                public string EnumName { get; set; }

                [NameInMap("enumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

        }

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
