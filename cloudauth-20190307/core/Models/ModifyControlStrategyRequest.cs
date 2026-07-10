// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyControlStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The list of security alert rules.</para>
        /// </summary>
        [NameInMap("ControlStrategyList")]
        [Validation(Required=false)]
        public List<ModifyControlStrategyRequestControlStrategyList> ControlStrategyList { get; set; }
        public class ModifyControlStrategyRequestControlStrategyList : TeaModel {
            /// <summary>
            /// <para>The API name, which is the same as <b>ProductCode</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The rule configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>QPS</b>: QPS greater than</description></item>
            /// <item><description><b>SUCCESS_RATE_5_MIN</b>: success rate in the last 5 minutes less than</description></item>
            /// <item><description><b>RESP_TIME_5_MIN</b>: average response time in the last 5 minutes greater than</description></item>
            /// <item><description><b>AMOUNT_RISE</b>: call volume increase compared to the previous period greater than</description></item>
            /// <item><description><b>AMOUNT_FALL</b>: call volume decrease compared to the previous period less than</description></item>
            /// <item><description><b>PASSED_RATE_1_HOUR</b>: verification consistency rate in the last hour less than</description></item>
            /// <item><description><b>PARAM_ERROR_RATE_1_HOUR</b>: parameter error rate in the last hour greater than.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS_RATE_5_MIN</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// <item><description><b>normal</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The alert threshold of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The product type. Currently, only <b>ANT_CLOUD_AUTH</b> (financial-grade ID Verification) is supported. All other types have been discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
