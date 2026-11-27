// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EditQualityProjectRequest : TeaModel {
        /// <summary>
        /// <para>The list of quality inspection rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AnalysisIds")]
        [Validation(Required=false)]
        public List<long?> AnalysisIds { get; set; }

        /// <summary>
        /// <para>The list of session channels.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChannelTouchType")]
        [Validation(Required=false)]
        public List<int?> ChannelTouchType { get; set; }

        /// <summary>
        /// <para>The check frequency type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Periodic quality inspection.</description></item>
        /// <item><description><b>4</b>: Temporary quality inspection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckFreqType")]
        [Validation(Required=false)]
        public int? CheckFreqType { get; set; }

        /// <summary>
        /// <para>The list of departments.</para>
        /// </summary>
        [NameInMap("DepList")]
        [Validation(Required=false)]
        public List<long?> DepList { get; set; }

        /// <summary>
        /// <para>The list of skill groups.</para>
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<long?> GroupList { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The Artificial Intelligence Cloud Call Service instance ID. You can obtain the ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the quality inspection task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automated quality inspection task</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The version of the quality inspection task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectVersion")]
        [Validation(Required=false)]
        public int? ProjectVersion { get; set; }

        /// <summary>
        /// <para>The quality inspection scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Instance (all skill groups).</description></item>
        /// <item><description><b>2</b>: Department or skill group list.</description></item>
        /// <item><description><b>3</b>: Customer service representative list.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public int? ScopeType { get; set; }

        /// <summary>
        /// <para>The list of customer service representatives.</para>
        /// </summary>
        [NameInMap("ServicerList")]
        [Validation(Required=false)]
        public List<string> ServicerList { get; set; }

        /// <summary>
        /// <para>The end time of the temporary quality inspection session. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619425576000</para>
        /// </summary>
        [NameInMap("TimeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the temporary quality inspection session. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1619424556000</para>
        /// </summary>
        [NameInMap("TimeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}
