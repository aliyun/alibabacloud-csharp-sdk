// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DeletePolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all versions of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: deletes all versions of the policy.</description></item>
        /// <item><description>false: does not delete all versions of the policy. If you set the parameter to false, the non-default versions of the policy are not deleted. Before you delete the policy, you must manually delete all non-default versions of the policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CascadingDelete")]
        [Validation(Required=false)]
        public bool? CascadingDelete { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS-Administrator</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
