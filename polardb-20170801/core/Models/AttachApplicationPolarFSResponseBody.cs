// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AttachApplicationPolarFSResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The actual container path to which the file system is mounted. If ContainerMountPath is not specified, the effective default value /mnt/<PolarFSInstanceId> is returned. If the file system is repeatedly mounted without changing the path, the original mount point of the instance is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/datasets</para>
        /// </summary>
        [NameInMap("ContainerMountPath")]
        [Validation(Required=false)]
        public string ContainerMountPath { get; set; }

        /// <summary>
        /// <para>The ID of the PolarLakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-**************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
