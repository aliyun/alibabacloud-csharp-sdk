// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleSaveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public InvoiceRuleSaveResponseBodyModule Module { get; set; }
        public class InvoiceRuleSaveResponseBodyModule : TeaModel {
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }
            [NameInMap("add_num")]
            [Validation(Required=false)]
            public int? AddNum { get; set; }
            [NameInMap("havana_id")]
            [Validation(Required=false)]
            public string HavanaId { get; set; }
            [NameInMap("remove_num")]
            [Validation(Required=false)]
            public int? RemoveNum { get; set; }
            [NameInMap("selected_external_user_num")]
            [Validation(Required=false)]
            public int? SelectedExternalUserNum { get; set; }
            [NameInMap("selected_user_num")]
            [Validation(Required=false)]
            public int? SelectedUserNum { get; set; }
            [NameInMap("suite_key")]
            [Validation(Required=false)]
            public string SuiteKey { get; set; }
            [NameInMap("token_grant_type")]
            [Validation(Required=false)]
            public int? TokenGrantType { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }
            [NameInMap("without_authority")]
            [Validation(Required=false)]
            public bool? WithoutAuthority { get; set; }
        };

        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
