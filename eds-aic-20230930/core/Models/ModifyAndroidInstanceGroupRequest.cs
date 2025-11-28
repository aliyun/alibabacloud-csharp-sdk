// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-cuv4scs4obxhs****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <para>The new name of the instance group.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The name can be up to 30 characters in length. It can contain letters, digits, colons (:), underscores (_), periods (.), or hyphens (-). It must start with letters but cannot start with http:// or https://.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>newName</para>
        /// </summary>
        [NameInMap("NewInstanceGroupName")]
        [Validation(Required=false)]
        public string NewInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-2w97kp89gnsif****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

    }

}
