// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class AttachWhitelistTemplateToInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AttachWhitelistTemplateToInstanceResponseBodyData Data { get; set; }
        public class AttachWhitelistTemplateToInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Instances that failed to be attached.</para>
            /// </summary>
            [NameInMap("AttachFailList")]
            [Validation(Required=false)]
            public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachFailList> AttachFailList { get; set; }
            public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachFailList : TeaModel {
                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The reason for the attachment failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>处理异常</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>Instances to which the template was successfully attached.</para>
            /// </summary>
            [NameInMap("AttachSuccessedList")]
            [Validation(Required=false)]
            public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedList> AttachSuccessedList { get; set; }
            public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedList : TeaModel {
                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The list of whitelist templates.</para>
                /// </summary>
                [NameInMap("Templates")]
                [Validation(Required=false)]
                public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplates> Templates { get; set; }
                public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplates : TeaModel {
                    /// <summary>
                    /// <para>The list of attached instances.</para>
                    /// </summary>
                    [NameInMap("DbInstances")]
                    [Validation(Required=false)]
                    public List<AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplatesDbInstances> DbInstances { get; set; }
                    public class AttachWhitelistTemplateToInstanceResponseBodyDataAttachSuccessedListTemplatesDbInstances : TeaModel {
                        /// <summary>
                        /// <para>The ID of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>asdfwef</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The IP address whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.1,10.0.0.1</para>
                    /// </summary>
                    [NameInMap("SecurityIPList")]
                    [Validation(Required=false)]
                    public string SecurityIPList { get; set; }

                    /// <summary>
                    /// <para>The ID of the whitelist template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g-asdfwem</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <para>The name of the whitelist template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo_template</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the operation. A value of <c>ok</c> indicates success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
