// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemsRequest : TeaModel {
        [NameInMap("affectServiceId")]
        [Validation(Required=false)]
        public long? AffectServiceId { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("discoveryEndTime")]
        [Validation(Required=false)]
        public string DiscoveryEndTime { get; set; }

        [NameInMap("discoveryStartTime")]
        [Validation(Required=false)]
        public string DiscoveryStartTime { get; set; }

        [NameInMap("mainHandlerId")]
        [Validation(Required=false)]
        public long? MainHandlerId { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        [NameInMap("problemStatus")]
        [Validation(Required=false)]
        public string ProblemStatus { get; set; }

        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("repeaterId")]
        [Validation(Required=false)]
        public long? RepeaterId { get; set; }

        [NameInMap("restoreEndTime")]
        [Validation(Required=false)]
        public string RestoreEndTime { get; set; }

        [NameInMap("restoreStartTime")]
        [Validation(Required=false)]
        public string RestoreStartTime { get; set; }

        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
