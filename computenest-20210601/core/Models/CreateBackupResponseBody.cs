// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-cad4a85ff5e340388b93</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8DC02957-A0FC-5AB2-8C54-496B636EAF12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the backup.</para>
        /// <list type="bullet">
        /// <item><description><para>Creating: The backup is being created.</para>
        /// </description></item>
        /// <item><description><para>Created: The backup is created.</para>
        /// </description></item>
        /// <item><description><para>CreateFailed: The backup failed to be created.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The backup is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The backup is deleted.</para>
        /// </description></item>
        /// <item><description><para>DeleteFailed: The backup failed to be deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
