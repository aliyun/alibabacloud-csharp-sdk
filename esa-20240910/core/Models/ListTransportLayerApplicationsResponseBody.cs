// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTransportLayerApplicationsResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTransportLayerApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListTransportLayerApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>170997271816****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com.ialicdn.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("CrossBorderOptimization")]
            [Validation(Required=false)]
            public string CrossBorderOptimization { get; set; }

            [NameInMap("IpAccessRule")]
            [Validation(Required=false)]
            public string IpAccessRule { get; set; }

            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public string Ipv6 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsRules> Rules { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ClientIPPassThroughMode")]
                [Validation(Required=false)]
                public string ClientIPPassThroughMode { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("EdgePort")]
                [Validation(Required=false)]
                public string EdgePort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20258028****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SourcePort")]
                [Validation(Required=false)]
                public string SourcePort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RulesCount")]
            [Validation(Required=false)]
            public int? RulesCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36556540048****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
