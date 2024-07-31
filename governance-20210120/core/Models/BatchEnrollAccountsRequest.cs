/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class BatchEnrollAccountsRequest : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestAccounts> Accounts { get; set; }
        public class BatchEnrollAccountsRequestAccounts : TeaModel {
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

        }

        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestBaselineItems> BaselineItems { get; set; }
        public class BatchEnrollAccountsRequestBaselineItems : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
