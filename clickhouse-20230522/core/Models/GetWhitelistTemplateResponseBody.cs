// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class GetWhitelistTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The whitelist template details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWhitelistTemplateResponseBodyData Data { get; set; }
        public class GetWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of whitelist templates.</para>
            /// </summary>
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<GetWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class GetWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                /// <summary>
                /// <para>The list of associated instances.</para>
                /// </summary>
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<GetWhitelistTemplateResponseBodyDataTemplatesDbInstances> DbInstances { get; set; }
                public class GetWhitelistTemplateResponseBodyDataTemplatesDbInstances : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cc-asdfwef</para>
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
