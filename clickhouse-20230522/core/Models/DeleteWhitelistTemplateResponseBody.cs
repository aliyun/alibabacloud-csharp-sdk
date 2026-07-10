// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DeleteWhitelistTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned from the call.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteWhitelistTemplateResponseBodyData Data { get; set; }
        public class DeleteWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The whitelist templates.</para>
            /// </summary>
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DeleteWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DeleteWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                /// <summary>
                /// <para>The instances associated with the template.</para>
                /// </summary>
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<DeleteWhitelistTemplateResponseBodyDataTemplatesDbInstances> DbInstances { get; set; }
                public class DeleteWhitelistTemplateResponseBodyDataTemplatesDbInstances : TeaModel {
                    /// <summary>
                    /// <para>The ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asdfwef</para>
                    /// </summary>
                    [NameInMap("DbInstanceName")]
                    [Validation(Required=false)]
                    public string DbInstanceName { get; set; }

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
