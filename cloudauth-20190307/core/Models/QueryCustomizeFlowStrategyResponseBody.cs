// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryCustomizeFlowStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Processing result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<QueryCustomizeFlowStrategyResponseBodyResultObject> ResultObject { get; set; }
        public class QueryCustomizeFlowStrategyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>AccumulateKey</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AccumulateKey")]
            [Validation(Required=false)]
            public string AccumulateKey { get; set; }

            /// <summary>
            /// <para>Flow control statistical window, unit: <b>minutes</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AccumulateWindow")]
            [Validation(Required=false)]
            public string AccumulateWindow { get; set; }

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
            /// <para>Flow type:</para>
            /// <list type="bullet">
            /// <item><description><b>ACCUMULATE</b>: ID card reappears</description></item>
            /// <item><description><b>PASSED_RATE</b>: Pass rate less than</description></item>
            /// <item><description><b>SUB_CODE_205</b>: Authentication failed and liveness attack 205 ratio greater than</description></item>
            /// <item><description><b>SUB_CODE_206</b>: Authentication failed and liveness attack 206 ratio greater than</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACCUMULATE</para>
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234822</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>match</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>Status:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled</description></item>
            /// <item><description><b>normal</b>: Enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>126005125163xxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Whether the response was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
