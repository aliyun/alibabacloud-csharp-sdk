// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class CreatePrivilegeCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        [NameInMap("strategyItems")]
        [Validation(Required=false)]
        public List<StrategyItem> StrategyItems { get; set; }

        [NameInMap("strategys")]
        [Validation(Required=false)]
        public string Strategys { get; set; }

    }

}
