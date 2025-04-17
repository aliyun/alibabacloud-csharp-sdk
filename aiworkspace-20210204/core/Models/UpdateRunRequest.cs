// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateRunRequest : TeaModel {
        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The run name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must be 1 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RunParam> Params { get; set; }

    }

}
