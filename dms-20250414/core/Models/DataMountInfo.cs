// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataMountInfo : TeaModel {
        /// <summary>
        /// <para>The name of the mount directory. The actual mount path is prefixed with /Workspace/data/.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("MountFolderName")]
        [Validation(Required=false)]
        public string MountFolderName { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The prefix. If this parameter is not specified, the root directory is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/prod</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>Whether to mount the data volume as read-only.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
