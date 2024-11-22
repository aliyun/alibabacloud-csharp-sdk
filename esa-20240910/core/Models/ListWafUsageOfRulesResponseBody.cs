// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafUsageOfRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The usage details of WAF rules of the website.</para>
        /// </summary>
        [NameInMap("Sites")]
        [Validation(Required=false)]
        public List<ListWafUsageOfRulesResponseBodySites> Sites { get; set; }
        public class ListWafUsageOfRulesResponseBodySites : TeaModel {
            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The usage of WAF rules or WAF rulesets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public long? Usage { get; set; }

        }

    }

}
