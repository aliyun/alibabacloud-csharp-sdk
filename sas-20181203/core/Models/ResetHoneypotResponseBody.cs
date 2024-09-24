// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ResetHoneypotResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the honeypot.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ResetHoneypotResponseBodyData Data { get; set; }
        public class ResetHoneypotResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the management node to which the honeypot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>managerNodename</para>
            /// </summary>
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            /// <summary>
            /// <para>The ID of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9bf8cd373112263d4bc102fc5dba9d9f812ee05d4d35c487d330d52e937f****</para>
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// <para>The display name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RuoYi</para>
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// <para>The name of the image that is used for the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruoyi</para>
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// <para>The custom name of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruoyi</para>
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// <para>The ID of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the custom configuration for the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>868a7579-00b5-4a74-999d-8bd3f411****</para>
            /// </summary>
            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public string PresetId { get; set; }

            /// <summary>
            /// <para>The statuses of the honeypots.</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public List<string> State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A57C711B-AA15-55B2-8F61-4D09CEXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
