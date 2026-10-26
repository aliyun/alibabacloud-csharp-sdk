// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ReportABMetricGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the baseline experiment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BaseExperimentId")]
        [Validation(Required=false)]
        public string BaseExperimentId { get; set; }

        /// <summary>
        /// <para>The dimension fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gender&quot;:&quot;man&quot;}</para>
        /// </summary>
        [NameInMap("DimensionFields")]
        [Validation(Required=false)]
        public string DimensionFields { get; set; }

        /// <summary>
        /// <para>The end date. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The ID of the experiment group. You can call the <a href="https://help.aliyun.com/document_detail/2402573.html">ListExperimentGroups</a> operation to obtain the ID. This parameter is required for offline and real-time reports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        /// <summary>
        /// <para>The list of experiment IDs. You can call the <a href="https://help.aliyun.com/document_detail/2402582.html">ListExperiments</a> operation to obtain the IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3,4,5</para>
        /// </summary>
        [NameInMap("ExperimentIds")]
        [Validation(Required=false)]
        public string ExperimentIds { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Realtime: real-time report</description></item>
        /// <item><description>Offline: offline report</description></item>
        /// <item><description>Market: dashboard report</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Offline</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can call the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The start date. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical time type. This parameter is required for real-time reports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour: hourly statistics</description></item>
        /// <item><description>Day: cumulative statistics starting from 00:00 on the current day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("TimeStatisticsMethod")]
        [Validation(Required=false)]
        public string TimeStatisticsMethod { get; set; }

    }

}
