// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;maxReplicas&quot;:3,&quot;minReplicas&quot;:1,&quot;metrics&quot;:[{&quot;metricType&quot;:&quot;CPU&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;MEMORY&quot;,&quot;metricTargetAverageUtilization&quot;:30},{&quot;metricType&quot;:&quot;tcpActiveConn&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;SLB_QPS&quot;,&quot;MetricTargetAverageUtilization&quot;:25,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-<b><b><b><b><b><b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;},{&quot;metricType&quot;:&quot;SLB_RT&quot;,&quot;MetricTargetAverageUtilization&quot;:35,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-</b></b></b></b></b></b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;}],&quot;scaleUpRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:0},&quot;scaleDownRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:300}}</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timer-0800-2100</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;beginDate&quot;:null,&quot;endDate&quot;:null,&quot;period&quot;:&quot;* * *&quot;,&quot;schedules&quot;:[{&quot;atTime&quot;:&quot;08:00&quot;,&quot;targetReplicas&quot;:10},{&quot;atTime&quot;:&quot;20:00&quot;,&quot;targetReplicas&quot;:3}]}</para>
        /// </summary>
        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timing</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
