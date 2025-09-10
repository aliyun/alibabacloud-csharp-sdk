// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class UpdateQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota alert.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a> operation to obtain the ID of a quota alert.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a> operation to obtain the name of a quota alert.</para>
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
        /// <item><description>If you set the <c>ThresholdType</c> parameter to <c>used</c>, you will receive an alert notification when the used quota is greater than or equal to the preset alert threshold. The alert threshold must be greater than the current used quota.</description></item>
        /// <item><description>If you set the <c>ThresholdType</c> parameter to <c>usable</c>, you will receive an alert notification when the available quota is less than or equal to the preset alert threshold. The alert threshold must be less than the current available quota.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must set one of the Threshold and ThresholdPercent parameters.</para>
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
        /// <item><description>If you set <c>ThresholdType</c> to <c>used</c>, you receive an alert notification when the used quota is greater than or equal to the preset percentage of the alert threshold. Value range: (50%, 100%].</description></item>
        /// <item><description>If you set <c>ThresholdType</c> to <c>usable</c>, you receive an alert notification when the available quota is less than or equal to the preset percentage of the alert threshold. Value range: (0%, 50%].</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must set one of Threshold and ThresholdPercent.</para>
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
        /// <item><description>used (default): The alert is created for the used quota.</description></item>
        /// <item><description>usable: The alert is created for the available quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>usable</para>
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// <para>The webhook URL. Quota Center sends alert notifications to the specified URL by using HTTP POST requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com/callback">https://alert.aliyun.com/callback</a></para>
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}
