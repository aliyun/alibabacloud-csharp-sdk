// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DetachWhitelistTemplateToInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetachWhitelistTemplateToInstanceResponseBodyData Data { get; set; }
        public class DetachWhitelistTemplateToInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of instances that failed to detach.</para>
            /// </summary>
            [NameInMap("DetachFailList")]
            [Validation(Required=false)]
            public List<DetachWhitelistTemplateToInstanceResponseBodyDataDetachFailList> DetachFailList { get; set; }
            public class DetachWhitelistTemplateToInstanceResponseBodyDataDetachFailList : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The reason the detach operation failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>处理异常</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>A list of successfully detached instances.</para>
            /// </summary>
            [NameInMap("DetachSuccessedList")]
            [Validation(Required=false)]
            public List<DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedList> DetachSuccessedList { get; set; }
            public class DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedList : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-database</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>A list of whitelist templates.</para>
                /// </summary>
                [NameInMap("Templates")]
                [Validation(Required=false)]
                public List<DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedListTemplates> Templates { get; set; }
                public class DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedListTemplates : TeaModel {
                    /// <summary>
                    /// <para>A list of associated instances.</para>
                    /// </summary>
                    [NameInMap("DbInstances")]
                    [Validation(Required=false)]
                    public List<DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedListTemplatesDbInstances> DbInstances { get; set; }
                    public class DetachWhitelistTemplateToInstanceResponseBodyDataDetachSuccessedListTemplatesDbInstances : TeaModel {
                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>asdfwef</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The IP whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.1,10.0.0.1</para>
                    /// </summary>
                    [NameInMap("SecurityIPList")]
                    [Validation(Required=false)]
                    public string SecurityIPList { get; set; }

                    /// <summary>
                    /// <para>The whitelist template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g-asdfwem</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <para>The whitelist template name.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
