// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class CreateNormalAccountRequest : TeaModel {
        [NameInMap("CreateNormalAccountInfoList")]
        [Validation(Required=false)]
        public List<CreateNormalAccountRequestCreateNormalAccountInfoList> CreateNormalAccountInfoList { get; set; }
        public class CreateNormalAccountRequestCreateNormalAccountInfoList : TeaModel {
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public long? AliyunPk { get; set; }

            [NameInMap("Cid")]
            [Validation(Required=false)]
            public long? Cid { get; set; }

            [NameInMap("CustomCredit")]
            [Validation(Required=false)]
            public string CustomCredit { get; set; }

            [NameInMap("CustomNick")]
            [Validation(Required=false)]
            public string CustomNick { get; set; }

            [NameInMap("CustomerAccount")]
            [Validation(Required=false)]
            public string CustomerAccount { get; set; }

            [NameInMap("CustomerRebateType")]
            [Validation(Required=false)]
            public string CustomerRebateType { get; set; }

            [NameInMap("FxDescription")]
            [Validation(Required=false)]
            public string FxDescription { get; set; }

            [NameInMap("FxShutdownstatus")]
            [Validation(Required=false)]
            public string FxShutdownstatus { get; set; }

            [NameInMap("isEnterprise")]
            [Validation(Required=false)]
            public int? IsEnterprise { get; set; }

        }

    }

}
