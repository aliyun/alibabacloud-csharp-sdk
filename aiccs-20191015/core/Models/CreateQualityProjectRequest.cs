// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateQualityProjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AnalysisIds")]
        [Validation(Required=false)]
        public List<long?> AnalysisIds { get; set; }

        [NameInMap("ChannelTouchType")]
        [Validation(Required=false)]
        public List<int?> ChannelTouchType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckFreqType")]
        [Validation(Required=false)]
        public int? CheckFreqType { get; set; }

        [NameInMap("DepList")]
        [Validation(Required=false)]
        public List<long?> DepList { get; set; }

        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<long?> GroupList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public int? ScopeType { get; set; }

        [NameInMap("ServicerList")]
        [Validation(Required=false)]
        public List<string> ServicerList { get; set; }

        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}
