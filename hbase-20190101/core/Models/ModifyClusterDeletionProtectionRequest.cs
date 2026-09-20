// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyClusterDeletionProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-****************</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables deletion protection. The cluster cannot be deleted when deletion protection is enabled.</description></item>
        /// <item><description>false: Disables deletion protection. The cluster can be deleted.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Protection")]
        [Validation(Required=false)]
        public bool? Protection { get; set; }

    }

}
