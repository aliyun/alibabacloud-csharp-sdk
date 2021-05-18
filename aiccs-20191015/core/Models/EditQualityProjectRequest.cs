// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EditQualityProjectRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("CheckFreqType")]
        [Validation(Required=false)]
        public int? CheckFreqType { get; set; }

        [NameInMap("ProjectVersion")]
        [Validation(Required=false)]
        public int? ProjectVersion { get; set; }

        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public int? ScopeType { get; set; }

        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        [NameInMap("AnalysisIds")]
        [Validation(Required=false)]
        public List<int?> AnalysisIds { get; set; }

        [NameInMap("DepList")]
        [Validation(Required=false)]
        public List<int?> DepList { get; set; }

        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<int?> GroupList { get; set; }

        [NameInMap("ServicerList")]
        [Validation(Required=false)]
        public List<string> ServicerList { get; set; }

        [NameInMap("ChannelTouchType")]
        [Validation(Required=false)]
        public List<int?> ChannelTouchType { get; set; }

    }

}
