// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasRequestTaskRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        [NameInMap("OperatorsRepeatList")]
        [Validation(Required=false)]
        public List<string> OperatorsRepeatList { get; set; }

        [NameInMap("OperatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> RequestIdsRepeatList { get; set; }

        [NameInMap("RequestStatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> RequestStatusesRepeatList { get; set; }

        [NameInMap("RequestTypesRepeatList")]
        [Validation(Required=false)]
        public List<string> RequestTypesRepeatList { get; set; }

        [NameInMap("ResourceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ResourceIdsRepeatList { get; set; }

        [NameInMap("ResourceTypesRepeatList")]
        [Validation(Required=false)]
        public List<string> ResourceTypesRepeatList { get; set; }

        [NameInMap("StatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> StatusesRepeatList { get; set; }

        [NameInMap("WorkspaceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkspaceIdsRepeatList { get; set; }

    }

}
