// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ListWhitelistTemplatesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWhitelistTemplatesResponseBodyData Data { get; set; }
        public class ListWhitelistTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrPageNumbers")]
            [Validation(Required=false)]
            public int? CurrPageNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasPrev")]
            [Validation(Required=false)]
            public bool? HasPrev { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<ListWhitelistTemplatesResponseBodyDataTemplates> Templates { get; set; }
            public class ListWhitelistTemplatesResponseBodyDataTemplates : TeaModel {
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<ListWhitelistTemplatesResponseBodyDataTemplatesDbInstances> DbInstances { get; set; }
                public class ListWhitelistTemplatesResponseBodyDataTemplatesDbInstances : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cc-asdfwef</para>
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.1,10.0.0.1</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>g-asdfwem</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>g-asdfwem</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalPageNumbers")]
            [Validation(Required=false)]
            public int? TotalPageNumbers { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
