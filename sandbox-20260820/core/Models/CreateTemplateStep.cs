// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateStep : TeaModel {
        /// <summary>
        /// <para>The instruction parameter list.</para>
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <para>The instruction type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUN</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
