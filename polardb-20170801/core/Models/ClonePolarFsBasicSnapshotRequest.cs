// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ClonePolarFsBasicSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Polarlakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-test*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The source path of the file resource. This parameter is empty if the type is local.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("SourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The destination path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/testclone</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

    }

}
