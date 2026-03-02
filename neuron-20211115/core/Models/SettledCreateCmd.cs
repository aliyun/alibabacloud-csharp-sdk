// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class SettledCreateCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("application")]
        [Validation(Required=false)]
        public string Application { get; set; }

        [NameInMap("developerName")]
        [Validation(Required=false)]
        public string DeveloperName { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("enterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
