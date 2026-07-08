// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetEffectivePolicyRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. Only <c>cn-shanghai</c> is supported.</para>
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

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

        /// <summary>
        /// <para>The ID of the target object.</para>
        /// <remarks>
        /// <para>This parameter is optional in Single-Account Mode and required in Multi-Account Mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>154950938137****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the target object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>USER: queries the effective policy for the current logon account. This value applies only to Single-Account Mode.</para>
        /// </description></item>
        /// <item><description><para>ROOT: queries the effective policy for the Root Folder in a Resource Directory. This value applies only to Multi-Account Mode.</para>
        /// </description></item>
        /// <item><description><para>FOLDER: queries the effective policy for a Folder in a Resource Directory. This value applies only to Multi-Account Mode.</para>
        /// </description></item>
        /// <item><description><para>ACCOUNT: queries the effective policy for a Member in a Resource Directory. This value applies only to Multi-Account Mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is optional in Single-Account Mode and required in Multi-Account Mode. The value is case-insensitive.</para>
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
