// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeAdvancedQueryTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1EC1FDC7-6D01-559F-852C-30D86E9EEB3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplatePage")]
        [Validation(Required=false)]
        public DescribeAdvancedQueryTemplateResponseBodyTemplatePage TemplatePage { get; set; }
        public class DescribeAdvancedQueryTemplateResponseBodyTemplatePage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public List<DescribeAdvancedQueryTemplateResponseBodyTemplatePageTemplateList> TemplateList { get; set; }
            public class DescribeAdvancedQueryTemplateResponseBodyTemplatePageTemplateList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SimpleQuery")]
                [Validation(Required=false)]
                public bool? SimpleQuery { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>utpl-7OaxbyJATDaoLOgZRcV5RQ</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>event.userIdentity.type: root-account AND event.userIdentity.accessKeyId: *</para>
                /// </summary>
                [NameInMap("TemplateSql")]
                [Validation(Required=false)]
                public string TemplateSql { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

    }

}
