// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lc-xxx</para>
        /// </summary>
        [NameInMap("LifecyclePolicyId")]
        [Validation(Required=false)]
        public string LifecyclePolicyId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclepolicy1</para>
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

    }

}
