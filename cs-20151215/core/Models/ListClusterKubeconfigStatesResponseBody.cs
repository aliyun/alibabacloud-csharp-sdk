// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterKubeconfigStatesResponseBody : TeaModel {
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListClusterKubeconfigStatesResponseBodyPage Page { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyPage : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListClusterKubeconfigStatesResponseBodyStates> States { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyStates : TeaModel {
            [NameInMap("account_display_name")]
            [Validation(Required=false)]
            public string AccountDisplayName { get; set; }

            [NameInMap("account_id")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("account_name")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("account_state")]
            [Validation(Required=false)]
            public string AccountState { get; set; }

            [NameInMap("account_type")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            [NameInMap("revokable")]
            [Validation(Required=false)]
            public bool? Revokable { get; set; }

        }

    }

}
