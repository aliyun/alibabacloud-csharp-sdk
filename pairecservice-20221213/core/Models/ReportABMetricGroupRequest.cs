// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ReportABMetricGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the base experiment.</para>
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
        /// <para>The end date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The ID of the experiment group. You can call the <a href="https://help.aliyun.com/document_detail/2402573.html">ListExperimentGroups</a> operation to obtain the ID of the experiment group. This parameter is required for offline and real-time reports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the experiments. You can call the <a href="https://help.aliyun.com/document_detail/2402582.html">ListExperiments</a> operation to obtain the IDs of the experiments.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3,4,5</para>
        /// </summary>
        [NameInMap("ExperimentIds")]
        [Validation(Required=false)]
        public string ExperimentIds { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the report.</para>
        /// <list type="bullet">
        /// <item><description><para>Realtime: real-time report.</para>
        /// </description></item>
        /// <item><description><para>Offline: offline report.</para>
        /// </description></item>
        /// <item><description><para>Market: dashboard report.</para>
        /// </description></item>
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
        /// <para>The ID of the scene. You can call the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation to obtain the scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The start date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The time statistics method. This parameter is required for real-time reports.</para>
        /// <list type="bullet">
        /// <item><description><para>Hour: The statistics are collected by hour.</para>
        /// </description></item>
        /// <item><description><para>Day: The statistics are accumulated from 00:00 on the current day.</para>
        /// </description></item>
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
