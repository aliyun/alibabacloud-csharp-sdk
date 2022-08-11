// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesRequest : TeaModel {
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("life_state")]
        [Validation(Required=false)]
        public string LifeState { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("online_state")]
        [Validation(Required=false)]
        public string OnlineState { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
