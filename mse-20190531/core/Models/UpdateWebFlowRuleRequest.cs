// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateWebFlowRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hkhon1****@c3df23522******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-a</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Burst")]
        [Validation(Required=false)]
        public int? Burst { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ControlBehavior")]
        [Validation(Required=false)]
        public int? ControlBehavior { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxQueueingTimeMs")]
        [Validation(Required=false)]
        public int? MaxQueueingTimeMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public int? MetricType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;fieldName&quot;:&quot;key&quot;,&quot;matchStrategy&quot;:2,&quot;parseStrategy&quot;:2,&quot;pattern&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ParamItem")]
        [Validation(Required=false)]
        public string ParamItem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResourceMode")]
        [Validation(Required=false)]
        public int? ResourceMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("StatIntervalMs")]
        [Validation(Required=false)]
        public int? StatIntervalMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
