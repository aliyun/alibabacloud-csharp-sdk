// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryEmbeddedInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The embedded information of the reports under the organization.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryEmbeddedInfoResponseBodyResult Result { get; set; }
        public class QueryEmbeddedInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Embed the statistics of the work.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public QueryEmbeddedInfoResponseBodyResultDetail Detail { get; set; }
            public class QueryEmbeddedInfoResponseBodyResultDetail : TeaModel {
                /// <summary>
                /// <para>The number of embedded self-service fetching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DashboardOfflineQuery")]
                [Validation(Required=false)]
                public int? DashboardOfflineQuery { get; set; }

                /// <summary>
                /// <para>The number of embedded dashboards.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                /// <summary>
                /// <para>The number of embedded spreadsheets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Report")]
                [Validation(Required=false)]
                public int? Report { get; set; }

            }

            /// <summary>
            /// <para>The number of reports that are currently embedded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EmbeddedCount")]
            [Validation(Required=false)]
            public int? EmbeddedCount { get; set; }

            /// <summary>
            /// <para>The maximum number of reports that can be embedded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
