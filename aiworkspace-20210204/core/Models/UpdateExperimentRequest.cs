// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The accessibility of the experiment in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: The experiment is accessible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: The experiment is accessible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The experiment name. The name must meet the following requirements:</para>
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

    }

}
