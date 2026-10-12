// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: The experiment is visible only to you and the administrator in the workspace.</description></item>
        /// <item><description>PUBLIC: The experiment is visible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The name of the experiment. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a lowercase or uppercase letter.</description></item>
        /// <item><description>The name can contain uppercase letters, lowercase letters, digits, underscores (_), or hyphens (-).</description></item>
        /// <item><description>The name must be 1 to 63 characters in length.</description></item>
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
