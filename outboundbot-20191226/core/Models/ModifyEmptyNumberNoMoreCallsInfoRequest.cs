// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyEmptyNumberNoMoreCallsInfoRequest : TeaModel {
        [NameInMap("EmptyNumberNoMoreCalls")]
        [Validation(Required=false)]
        public bool? EmptyNumberNoMoreCalls { get; set; }

        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

    }

}
