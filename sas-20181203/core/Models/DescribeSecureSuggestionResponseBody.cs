// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1755744253000</para>
        /// </summary>
        [NameInMap("CalTime")]
        [Validation(Required=false)]
        public long? CalTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>676F80E3-4B3F-43DA-9CBB-5FF79F202AA2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Suggestions")]
        [Validation(Required=false)]
        public List<DescribeSecureSuggestionResponseBodySuggestions> Suggestions { get; set; }
        public class DescribeSecureSuggestionResponseBodySuggestions : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSecureSuggestionResponseBodySuggestionsDetail> Detail { get; set; }
            public class DescribeSecureSuggestionResponseBodySuggestionsDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Malicious tampering of Web pages will affect your normal access to web page content, and may also lead to serious economic losses, brand losses, and even political risks. The webpage tamper-proof service can monitor the website directory in real time and restore the tampered files or directories through backup, so as to ensure that the website information of important systems is not tampered with maliciously and prevent the occurrence of horse hanging, black chain, illegal implantation of terrorist threats, pornography and other content.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REINFORCE_WEB_LOCK</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Website tamper-proofing capability not configured</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public int? Points { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SS_ALARM</para>
            /// </summary>
            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
