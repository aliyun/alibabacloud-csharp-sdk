// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QuerySecurityCheckReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para> 200: The request was successful. Other codes (such as 500 or 400): An error occurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySecurityCheckReportResponseBodyData Data { get; set; }
        public class QuerySecurityCheckReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The subscription status of the cloud security guide. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not subscribed </description></item>
            /// <item><description><b>1</b>: subscribed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CloudSecurityGuide")]
            [Validation(Required=false)]
            public int? CloudSecurityGuide { get; set; }

            /// <summary>
            /// <para>The number of pending items for configuration audit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConfigCheckNumber")]
            [Validation(Required=false)]
            public int? ConfigCheckNumber { get; set; }

            /// <summary>
            /// <para>The number of pending items for security contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ContactCheckNumber")]
            [Validation(Required=false)]
            public int? ContactCheckNumber { get; set; }

            /// <summary>
            /// <para>The number of risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RiskEventNumber")]
            [Validation(Required=false)]
            public int? RiskEventNumber { get; set; }

            /// <summary>
            /// <para>The number of pending items for Elastic Compute Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SasCheckNumber")]
            [Validation(Required=false)]
            public int? SasCheckNumber { get; set; }

            /// <summary>
            /// <para>The security check result status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no risk</description></item>
            /// <item><description><b>1</b>: risks exist </description></item>
            /// <item><description><b>2</b>: items to be optimized exist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityStatus")]
            [Validation(Required=false)]
            public int? SecurityStatus { get; set; }

            /// <summary>
            /// <para>The suggestion text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exist risk event。</para>
            /// </summary>
            [NameInMap("SuggestionText")]
            [Validation(Required=false)]
            public string SuggestionText { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
