// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DeleteWhitelistTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteWhitelistTemplateResponseBodyData Data { get; set; }
        public class DeleteWhitelistTemplateResponseBodyData : TeaModel {
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DeleteWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DeleteWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<DeleteWhitelistTemplateResponseBodyDataTemplatesDbInstances> DbInstances { get; set; }
                public class DeleteWhitelistTemplateResponseBodyDataTemplatesDbInstances : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>asdfwef</para>
                    /// </summary>
                    [NameInMap("DbInstanceName")]
                    [Validation(Required=false)]
                    public string DbInstanceName { get; set; }

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

            }

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
