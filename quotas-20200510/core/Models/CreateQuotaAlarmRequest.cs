// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaAlarmRequest : Darabonba.Model {
        /// <summary>
        /// <para>The name of the quota alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_hvnoqv alarm</para>
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// <para>The original context information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OriginalContext")]
        [Validation(Required=false)]
        public string OriginalContext { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviation of a cloud service, see ProductCode in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>config</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the quota ID of a cloud service, see QuotaActionCode in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_hvnoqv</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota dimensions.
        /// The dimensions are properties of a quota item. A quota item is uniquely identified by Dimensions and QuotaActionCode.</para>
        /// <remarks>
        /// <para>Some dimensions are required for specific cloud services. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the supported quota dimensions of a cloud service. The Requisite response parameter indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaAlarmRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class CreateQuotaAlarmRequestQuotaDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para>You must specify both Dimensions.N.Key and Dimensions.N.Value. The value range of N depends on the number of dimensions supported by the cloud service. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the supported quota dimensions. The length of the returned array is the maximum value of N.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension.</para>
            /// <remarks>
            /// <para>You must specify both Dimensions.N.Key and Dimensions.N.Value. The value range of N depends on the number of dimensions supported by the cloud service. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the supported quota dimensions. The length of the returned array is the maximum value of N.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The numeric value of the quota alert threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If ThresholdType is set to used, you receive an alert notification when the used quota is greater than or equal to the specified value. The quota alert threshold must be greater than the used quota.</para>
        /// </description></item>
        /// <item><description><para>If ThresholdType is set to usable, you receive an alert notification when the available quota is less than or equal to the specified value. The quota alert threshold must be less than the available quota.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify either this parameter or ThresholdPercent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The percentage of the quota alert threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If ThresholdType is set to used, you receive an alert notification when the used quota is greater than or equal to the specified percentage. Valid values: (50%, 100%].</para>
        /// </description></item>
        /// <item><description><para>If ThresholdType is set to usable, you receive an alert notification when the available quota is less than or equal to the specified percentage. Valid values: (0%, 50%].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify either this parameter or Threshold.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ThresholdPercent")]
        [Validation(Required=false)]
        public float? ThresholdPercent { get; set; }

        /// <summary>
        /// <para>The quota alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>used: alerts on the used quota. This is the default value.</description></item>
        /// <item><description>usable: alerts on the remaining available quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>used</para>
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// <para>The public URL to which Quota Center sends alert notifications by using HTTP POST requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com/callback">https://alert.aliyun.com/callback</a></para>
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}

