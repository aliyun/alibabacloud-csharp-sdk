// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeCustomerModuleOutputInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>055f1546-f465-4c92-a2da-bfb86abe6f56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeCustomerModuleOutputInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeCustomerModuleOutputInfoResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Number of decimal places for the output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FinalScoreFormat")]
            [Validation(Required=false)]
            public string FinalScoreFormat { get; set; }

            /// <summary>
            /// <para>Score processing logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>score</para>
            /// </summary>
            [NameInMap("ProcessExpression")]
            [Validation(Required=false)]
            public string ProcessExpression { get; set; }

            /// <summary>
            /// <para>Test file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer/xxxxxxxxx/xxxxxxxx.pmml</para>
            /// </summary>
            [NameInMap("TestFile")]
            [Validation(Required=false)]
            public string TestFile { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful, with possible values as follows:</para>
        /// <list type="bullet">
        /// <item><description>true, indicating the request was successful</description></item>
        /// <item><description>false, indicating the request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
