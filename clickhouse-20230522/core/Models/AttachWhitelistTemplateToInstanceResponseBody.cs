// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class AttachWhitelistTemplateToInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AttachWhitelistTemplateToInstanceResponseBodyData Data { get; set; }
        public class AttachWhitelistTemplateToInstanceResponseBodyData : TeaModel {
            [NameInMap("AttachFailList")]
            [Validation(Required=false)]
            public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachFailList> AttachFailList { get; set; }
            public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachFailList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>处理异常</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            [NameInMap("AttachSuccessedList")]
            [Validation(Required=false)]
            public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedList> AttachSuccessedList { get; set; }
            public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("Templates")]
                [Validation(Required=false)]
                public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplates> Templates { get; set; }
                public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplates : TeaModel {
                    [NameInMap("DbInstances")]
                    [Validation(Required=false)]
                    public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplatesDbInstances> DbInstances { get; set; }
                    public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplatesDbInstances : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>asdfwef</para>
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
                    /// <para>demo_template</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
