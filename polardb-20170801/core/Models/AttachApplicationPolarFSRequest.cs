// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AttachApplicationPolarFSRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The mount point of the file system visible in the application container. If this parameter is not specified, the default value /mnt/<PolarFSInstanceId> is used for the first mount. For subsequent mounts, the current mount point of the instance remains unchanged. The value must be an absolute path that starts with a forward slash (/) but cannot be the root directory (/). It can only contain letters, digits, periods (.), underscores (_), hyphens (-), and forward slashes (/). The total length cannot exceed 128 characters, the directory depth cannot exceed 6 levels, and the length of a single level cannot exceed 63 characters. The mount point cannot be identical to or a subdirectory of the mount points of other file systems under the same application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/datasets</para>
        /// </summary>
        [NameInMap("ContainerMountPath")]
        [Validation(Required=false)]
        public string ContainerMountPath { get; set; }

        /// <summary>
        /// <para>The AccessKey ID of the Alibaba Cloud account or RAM user. Ensure that the account or RAM user is authorized when you create the PolarLakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LT**********************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeyId")]
        [Validation(Required=false)]
        public string PolarFSAccessKeyId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret of the Alibaba Cloud account or RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H3****************************</para>
        /// </summary>
        [NameInMap("PolarFSAccessKeySecret")]
        [Validation(Required=false)]
        public string PolarFSAccessKeySecret { get; set; }

        /// <summary>
        /// <para>The PolarLakebase cold storage instance ID.</para>
        /// <para>Currently, only the following applications support cold storage instances:</para>
        /// <list type="bullet">
        /// <item><description>supabase</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-**************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

    }

}
