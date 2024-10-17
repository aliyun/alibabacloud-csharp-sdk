// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-cuv4scs4obxhs****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>newName</para>
        /// </summary>
        [NameInMap("NewInstanceGroupName")]
        [Validation(Required=false)]
        public string NewInstanceGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pg-2w97kp89gnsif****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

    }

}
