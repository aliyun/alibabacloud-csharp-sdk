// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>Backup ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-cad4a85ff5e340388b93</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8DC02957-A0FC-5AB2-8C54-496B636EAF12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Backup status </para>
        /// <list type="bullet">
        /// <item><description>Creating: In progress </description></item>
        /// <item><description>Created: Success </description></item>
        /// <item><description>CreateFailed: Failed </description></item>
        /// <item><description>Deleting: In progress </description></item>
        /// <item><description>Deleted: Success </description></item>
        /// <item><description>DeleteFailed: Failed</description></item>
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
