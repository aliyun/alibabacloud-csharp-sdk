// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the experiment in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE: The experiment is visible only to you and the administrator in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The experiment is visible to everyone in the workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The name of the experiment. The naming convention is as follows:</para>
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

    }

}
