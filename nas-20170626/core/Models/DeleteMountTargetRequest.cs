// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose NAS: 31a8e4****.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: must start with <c>extreme-</c>, such as extreme-0015****.</para>
        /// </description></item>
        /// <item><description><para>CPFS: must start with <c>cpfs-</c>, such as cpfs-125487****.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The mount target.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494b666-x****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

    }

}
