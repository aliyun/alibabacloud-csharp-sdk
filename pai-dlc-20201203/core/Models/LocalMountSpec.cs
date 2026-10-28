// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class LocalMountSpec : TeaModel {
        /// <summary>
        /// <para>The local path on the host. This field is invalid when MountMode is set to Block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/local/a</para>
        /// </summary>
        [NameInMap("LocalPath")]
        [Validation(Required=false)]
        public string LocalPath { get; set; }

        /// <summary>
        /// <para>The mount mode. Valid values: Block and Filesystem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Filesystem</para>
        /// </summary>
        [NameInMap("MountMode")]
        [Validation(Required=false)]
        public string MountMode { get; set; }

        /// <summary>
        /// <para>The absolute mount path in the container. The path must start with a forward slash (/). When MountMode is set to Block, the path must start with /dev/.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

    }

}
