// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-iBuGU1VxEY42zrQRQfNA****</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTools")]
        [Validation(Required=false)]
        public bool? EnableTools { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        [NameInMap("Tools")]
        [Validation(Required=false)]
        public List<string> Tools { get; set; }

    }

}
