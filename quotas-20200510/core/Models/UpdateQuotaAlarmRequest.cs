// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class UpdateQuotaAlarmRequest : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the quota alert.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the ID of a quota alert, see <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2efa7fc-832f-47bb-8054-39e28012****</para>
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        /// <summary>
        /// <para>The name of the quota alert.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the name of a quota alert, see <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rules</para>
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// <para>The numeric value of the alert threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>ThresholdType</c> to <c>used</c>, an alert is triggered when the used quota is greater than or equal to this value. The alert threshold must be greater than the current used quota.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>ThresholdType</c> to <c>usable</c>, an alert is triggered when the usable quota is less than or equal to this value. The alert threshold must be less than the current usable quota.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must set either Threshold or ThresholdPercent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The percentage of the alert threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>ThresholdType</c> to <c>used</c>, an alert is triggered when the percentage of the used quota is greater than or equal to this value. The value must be in the range of (50%, 100%].</para>
        /// </description></item>
        /// <item><description><para>If you set <c>ThresholdType</c> to <c>usable</c>, an alert is triggered when the percentage of the usable quota is less than or equal to this value. The value must be in the range of (0%, 50%].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must set either Threshold or ThresholdPercent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("ThresholdPercent")]
        [Validation(Required=false)]
        public float? ThresholdPercent { get; set; }

        /// <summary>
        /// <para>The type of the quota alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>used (default): The alert is triggered based on the used quota.</para>
        /// </description></item>
        /// <item><description><para>usable: The alert is triggered based on the usable quota.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>usable</para>
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// <para>The webhook URL. Quota Center sends alert notifications to this URL using an HTTP POST request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com/callback">https://alert.aliyun.com/callback</a></para>
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}

