// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListWebFilterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of web filtering templates that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of web filtering templates.</para>
        /// </summary>
        [NameInMap("WebFilterTemplates")]
        [Validation(Required=false)]
        public List<ListWebFilterTemplatesResponseBodyWebFilterTemplates> WebFilterTemplates { get; set; }
        public class ListWebFilterTemplatesResponseBodyWebFilterTemplates : TeaModel {
            /// <summary>
            /// <para>The creation time of the web filtering template. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the web filtering template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web filtering template for URL access control</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the web filtering template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web filtering template 01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The statistics on the number of web filtering rules in the template categorized by action.</para>
            /// </summary>
            [NameInMap("RuleActionStatistics")]
            [Validation(Required=false)]
            public ListWebFilterTemplatesResponseBodyWebFilterTemplatesRuleActionStatistics RuleActionStatistics { get; set; }
            public class ListWebFilterTemplatesResponseBodyWebFilterTemplatesRuleActionStatistics : TeaModel {
                /// <summary>
                /// <para>The number of web filtering rules whose action is Alert in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Alert")]
                [Validation(Required=false)]
                public long? Alert { get; set; }

                /// <summary>
                /// <para>The number of web filtering rules whose action is Allow in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Allow")]
                [Validation(Required=false)]
                public long? Allow { get; set; }

                /// <summary>
                /// <para>The number of web filtering rules whose action is Deny in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Deny")]
                [Validation(Required=false)]
                public long? Deny { get; set; }

            }

            /// <summary>
            /// <para>The status of the web filtering template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the web filtering template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wft-3f2a9c1d4b5e6f70</para>
            /// </summary>
            [NameInMap("WebFilterTemplateId")]
            [Validation(Required=false)]
            public string WebFilterTemplateId { get; set; }

        }

    }

}
