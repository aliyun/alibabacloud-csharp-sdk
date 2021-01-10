// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeAppServiceEnvParamRequest : TeaModel {
        [NameInMap("CreationTimeFrom")]
        [Validation(Required=false)]
        public string CreationTimeFrom { get; set; }

        [NameInMap("CreationTimeTo")]
        [Validation(Required=false)]
        public string CreationTimeTo { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("Descend")]
        [Validation(Required=false)]
        public bool? Descend { get; set; }

        [NameInMap("IsProcessed")]
        [Validation(Required=false)]
        public bool? IsProcessed { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("ModificationTimeFrom")]
        [Validation(Required=false)]
        public string ModificationTimeFrom { get; set; }

        [NameInMap("ModificationTimeTo")]
        [Validation(Required=false)]
        public string ModificationTimeTo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("AppIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppIdsRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServiceIdsRepeatList { get; set; }

        [NameInMap("BuildpackIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> BuildpackIdsRepeatList { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

    }

}
