// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateRunRequest : TeaModel {
        /// <summary>
        /// <para>A list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The name of the run. The naming conventions are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Must start with a lowercase or uppercase letter.</para>
        /// </description></item>
        /// <item><description><para>Can contain lowercase letters, uppercase letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>The length must be 1 to 63 characters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A list of parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RunParam> Params { get; set; }

    }

}
