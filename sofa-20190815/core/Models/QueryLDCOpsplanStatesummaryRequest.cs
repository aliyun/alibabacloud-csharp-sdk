// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCOpsplanStatesummaryRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("CreationTimeFrom")]
        [Validation(Required=false)]
        public string CreationTimeFrom { get; set; }

        [NameInMap("CreationTimeTo")]
        [Validation(Required=false)]
        public string CreationTimeTo { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PlanIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> PlanIdsRepeatList { get; set; }

        [NameInMap("StateListRepeatList")]
        [Validation(Required=false)]
        public List<string> StateListRepeatList { get; set; }

        [NameInMap("TimeSeriesId")]
        [Validation(Required=false)]
        public string TimeSeriesId { get; set; }

        [NameInMap("TypesRepeatList")]
        [Validation(Required=false)]
        public List<string> TypesRepeatList { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
