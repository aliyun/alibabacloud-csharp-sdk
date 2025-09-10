// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// <para>Quota alarm name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_344t4 alarm</para>
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        [NameInMap("OriginalContext")]
        [Validation(Required=false)]
        public string OriginalContext { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, check the <c>ProductCode</c> parameter that is described in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
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
        /// <para> To obtain the quota ID of an Alibaba Cloud service, call the <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a> operation and check the value of <c>QuotaActionCode</c> in the response.</para>
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
        /// <para>The quota dimensions. A quota item is uniquely identified by the values of <c>Dimensions</c> and <c>QuotaActionCode</c>.</para>
        /// <remarks>
        /// <para> This parameter is required for specific Alibaba Cloud services. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the quota dimensions that are supported by an Alibaba Cloud service. The value of <c>Requisite</c> in the response indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaAlarmRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class CreateQuotaAlarmRequestQuotaDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension.</para>
            /// <remarks>
            /// <para> You must configure <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> at the same time. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the dimensions that are supported by an Alibaba Cloud service. The number of items in the returned array is N.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the dimension.</para>
            /// <remarks>
            /// <para> You must configure <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> at the same time. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. You can call the <a href="https://help.aliyun.com/document_detail/440553.html">ListProductQuotaDimensions</a> operation to query the dimensions that are supported by an Alibaba Cloud service. The number of items in the returned array is N.</para>
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
        /// <para>The numerical value of the quota alarm threshold. Value settings:</para>
        /// <list type="bullet">
        /// <item><description>When <c>ThresholdType</c> is set to <c>used</c>, an alarm notification will be sent if the used amount of the quota is greater than or equal to the preset value. The quota alarm threshold must be greater than the used amount of the quota.</description></item>
        /// <item><description>When <c>ThresholdType</c> is set to <c>usable</c>, an alarm notification will be sent if the remaining available amount of the quota is less than or equal to the preset value. The quota alarm threshold must be less than the remaining available amount of the quota.<remarks>
        /// <para>One of this parameter and ThresholdPercent must be set.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The percentage of the quota alert threshold. Values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>ThresholdType</c> is set to <c>used</c>, you will receive an alert notification if the used amount of the quota is greater than or equal to the preset percentage. The value range is (50%, 100%].</description></item>
        /// <item><description>When <c>ThresholdType</c> is set to <c>usable</c>, you will receive an alert notification if the remaining available amount of the quota is less than or equal to the preset percentage. The value range is (0%, 50%].<remarks>
        /// <para>One of this parameter and Threshold must be set.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
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
        /// <para>used</para>
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// <para>The quota center sends alert information to the specified public URL address via a POST request using the HTTP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com/callback">https://alert.aliyun.com/callback</a></para>
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}
