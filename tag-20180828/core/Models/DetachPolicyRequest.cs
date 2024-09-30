// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class DetachPolicyRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the tag policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-a3381efe2fe34a75****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the object.</para>
        /// <remarks>
        /// <para> If you use the Tag Policy feature in single-account mode, this parameter is optional. If you use the Tag Policy feature in multi-account mode, this feature is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
        /// <item><description>ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you use the Tag Policy feature in single-account mode, this parameter is optional. If you use the Tag Policy feature in multi-account mode, this feature is required. The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ACCOUNT</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
