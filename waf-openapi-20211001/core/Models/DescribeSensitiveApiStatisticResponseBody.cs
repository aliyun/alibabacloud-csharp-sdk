// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveApiStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveApiStatisticResponseBodyData> Data { get; set; }
        public class DescribeSensitiveApiStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of personal information records involved in cross-border data transfer by domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213</para>
            /// </summary>
            [NameInMap("InfoOutboundCount")]
            [Validation(Required=false)]
            public long? InfoOutboundCount { get; set; }

            /// <summary>
            /// <para>The domain name-related APIs.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSensitiveApiStatisticResponseBodyDataList> List { get; set; }
            public class DescribeSensitiveApiStatisticResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/login</para>
                /// </summary>
                [NameInMap("ApiFormat")]
                [Validation(Required=false)]
                public string ApiFormat { get; set; }

                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d288137009c119a873d4c395****</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The number of personal information records involved in cross-border data transfer by API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("InfoCount")]
                [Validation(Required=false)]
                public long? InfoCount { get; set; }

                /// <summary>
                /// <para>The types of sensitive data.</para>
                /// </summary>
                [NameInMap("SensitiveCode")]
                [Validation(Required=false)]
                public List<string> SensitiveCode { get; set; }

                /// <summary>
                /// <para>The number of sensitive personal information records involved in cross-border data transfer by API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

            }

            /// <summary>
            /// <para>The domain name or IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>www.***.top</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The number of sensitive personal information records involved in cross-border data transfer by domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127</para>
            /// </summary>
            [NameInMap("SensitiveOutboundCount")]
            [Validation(Required=false)]
            public long? SensitiveOutboundCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
