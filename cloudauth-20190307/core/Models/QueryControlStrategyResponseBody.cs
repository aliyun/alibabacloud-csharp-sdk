// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryControlStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B506328A-D84B-4750-82C7-6A207C585CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Processing result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<QueryControlStrategyResponseBodyResultObject> ResultObject { get; set; }
        public class QueryControlStrategyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>API name, same as the <b>ProductCode</b> of the authentication interface.</para>
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
            /// <para>234822</para>
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
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Alarm threshold for rule configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            /// <summary>
            /// <para>User ID.</para>
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
