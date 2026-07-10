// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryControlStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B506328A-D84B-4750-82C7-6A207C585CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The processing result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<QueryControlStrategyResponseBodyResultObject> ResultObject { get; set; }
        public class QueryControlStrategyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The API name, which is the same as the ProductCode of the verification operation.</para>
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
            /// <para>234822</para>
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
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The alert threshold for configure alerting of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>126005125163xxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
