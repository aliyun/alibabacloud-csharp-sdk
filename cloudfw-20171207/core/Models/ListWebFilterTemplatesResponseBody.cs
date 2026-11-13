// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListWebFilterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("WebFilterTemplates")]
        [Validation(Required=false)]
        public List<ListWebFilterTemplatesResponseBodyWebFilterTemplates> WebFilterTemplates { get; set; }
        public class ListWebFilterTemplatesResponseBodyWebFilterTemplates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用于URL访问管控的Web过滤模板</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Web过滤模板01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RuleActionStatistics")]
            [Validation(Required=false)]
            public ListWebFilterTemplatesResponseBodyWebFilterTemplatesRuleActionStatistics RuleActionStatistics { get; set; }
            public class ListWebFilterTemplatesResponseBodyWebFilterTemplatesRuleActionStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Alert")]
                [Validation(Required=false)]
                public long? Alert { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Allow")]
                [Validation(Required=false)]
                public long? Allow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Deny")]
                [Validation(Required=false)]
                public long? Deny { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wft-3f2a9c1d4b5e6f70</para>
            /// </summary>
            [NameInMap("WebFilterTemplateId")]
            [Validation(Required=false)]
            public string WebFilterTemplateId { get; set; }

        }

    }

}
