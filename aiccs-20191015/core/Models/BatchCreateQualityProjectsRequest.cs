// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class BatchCreateQualityProjectsRequest : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}
