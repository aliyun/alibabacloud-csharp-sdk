// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class DataResourceValue : TeaModel {
        /// <summary>
        /// <para>The resource name (including the file name extension).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample.md</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource type: template, data, script, etc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The resource content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a sample file.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The resource metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

    }

}
