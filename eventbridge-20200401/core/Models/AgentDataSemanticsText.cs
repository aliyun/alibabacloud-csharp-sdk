// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsText : TeaModel {
        /// <summary>
        /// <para>The content of the Markdown-formatted text knowledge.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>Data description</h2>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
