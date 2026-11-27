// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class BatchCreateQualityProjectsRequest : TeaModel {
        /// <summary>
        /// <para>The list of quality check rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AnalysisIds")]
        [Validation(Required=false)]
        public List<long?> AnalysisIds { get; set; }

        /// <summary>
        /// <para>The list of session channels.</para>
        /// </summary>
        [NameInMap("ChannelTouchType")]
        [Validation(Required=false)]
        public List<int?> ChannelTouchType { get; set; }

        /// <summary>
        /// <para>The check frequency type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: periodic quality check</description></item>
        /// <item><description><b>4</b>: ad-hoc quality check</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CheckFreqType")]
        [Validation(Required=false)]
        public int? CheckFreqType { get; set; }

        /// <summary>
        /// <para>The list of instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        /// <summary>
        /// <para>The name of the quality check task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automated quality check task</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The end time of the ad-hoc quality check session. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619425576000</para>
        /// </summary>
        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the ad-hoc quality check session. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619424556000</para>
        /// </summary>
        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}
