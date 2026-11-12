// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeletePolarFsObjectsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The list of files to delete. Parameter value examples:</para>
        /// <list type="bullet">
        /// <item><description><b>Cold Storage Edition</b> Example directory path to delete: test001/</description></item>
        /// <item><description><b>Cold Storage Edition</b> Example file path to delete: test001/file.txt</description></item>
        /// <item><description><b>Basic Edition</b> Example directory path to delete: /dir</description></item>
        /// <item><description><b>Basic Edition</b> Example file path to delete: /dir/file.txt</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectsToDelete")]
        [Validation(Required=false)]
        public string ObjectsToDeleteShrink { get; set; }

        /// <summary>
        /// <para>The PolarLakebase instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i7*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
