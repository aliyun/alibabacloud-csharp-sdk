// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAED912D-909E-45F0-AF74-AC0CCDCAE314</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of custom frequency control rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The custom frequency control rule.</para>
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// <para>The action triggered if the rule is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>close</b>: The requests that match the rule are blocked.</description></item>
            /// <item><description><b>captcha</b>: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>close</para>
            /// </summary>
            [NameInMap("Act")]
            [Validation(Required=false)]
            public string Act { get; set; }

            /// <summary>
            /// <para>The number of requests that are allowed from a single IP address. Valid values: <b>2</b> to <b>2000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The check interval. Valid values: <b>5</b> to <b>10800</b>. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The match mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>prefix</b>: prefix match.</description></item>
            /// <item><description><b>match</b>: exact match.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prefix</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wq</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The validity period. Valid values: <b>1</b> to <b>1440</b>. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The check path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/hello</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
