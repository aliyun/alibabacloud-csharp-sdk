// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeAdvancedQueryTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EC1FDC7-6D01-559F-852C-30D86E9EEB3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paginated list of templates.</para>
        /// </summary>
        [NameInMap("TemplatePage")]
        [Validation(Required=false)]
        public DescribeAdvancedQueryTemplateResponseBodyTemplatePage TemplatePage { get; set; }
        public class DescribeAdvancedQueryTemplateResponseBodyTemplatePage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of results returned.
            /// Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The list of template details.</para>
            /// </summary>
            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public List<DescribeAdvancedQueryTemplateResponseBodyTemplatePageTemplateList> TemplateList { get; set; }
            public class DescribeAdvancedQueryTemplateResponseBodyTemplatePageTemplateList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the simple query mode is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SimpleQuery")]
                [Validation(Required=false)]
                public bool? SimpleQuery { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utpl-7OaxbyJATDaoLOgZRc****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-template</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The query statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>event.userIdentity.type: root-account AND event.userIdentity.accessKeyId: *</para>
                /// </summary>
                [NameInMap("TemplateSql")]
                [Validation(Required=false)]
                public string TemplateSql { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

    }

}
