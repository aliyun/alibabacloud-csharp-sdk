// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyControlStrategyRequest : TeaModel {
        /// <summary>
        /// <para>List of security alarm rules.</para>
        /// </summary>
        [NameInMap("ControlStrategyList")]
        [Validation(Required=false)]
        public List<ModifyControlStrategyRequestControlStrategyList> ControlStrategyList { get; set; }
        public class ModifyControlStrategyRequestControlStrategyList : TeaModel {
            /// <summary>
            /// <para>API name, same as <b>ProductCode</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>Rule configuration type:</para>
            /// <list type="bullet">
            /// <item><description><b>QPS</b>: QPS greater than</description></item>
            /// <item><description><b>SUCCESS_RATE_5_MIN</b>: Success rate in the last 5 minutes less than</description></item>
            /// <item><description><b>RESP_TIME_5_MIN</b>: Average response time in the last 5 minutes greater than</description></item>
            /// <item><description><b>AMOUNT_RISE</b>: Call volume growth ratio greater than</description></item>
            /// <item><description><b>AMOUNT_FALL</b>: Call volume decline ratio less than</description></item>
            /// <item><description><b>PASSED_RATE_1_HOUR</b>: Verification consistency rate in the last hour less than</description></item>
            /// <item><description><b>PARAM_ERROR_RATE_1_HOUR</b>: Parameter error rate in the last hour greater than</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS_RATE_5_MIN</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Status:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled</description></item>
            /// <item><description><b>normal</b>: Enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Alarm threshold for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

        }

        /// <summary>
        /// <para>Product type, currently only supports <b>ANT_CLOUD_AUTH</b> (Financial-grade Real Person), all others are phased out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Region ID of the intelligent access gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
