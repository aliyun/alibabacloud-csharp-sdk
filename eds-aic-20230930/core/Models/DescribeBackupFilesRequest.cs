// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBackupFilesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acp-34pqe4r0kd9kn****</para>
        /// </summary>
        [NameInMap("AndroidInstanceId")]
        [Validation(Required=false)]
        public string AndroidInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acp-34pqe4r0kd9kn****</para>
        /// </summary>
        [NameInMap("AndroidInstanceName")]
        [Validation(Required=false)]
        public string AndroidInstanceName { get; set; }

        [NameInMap("BackupAll")]
        [Validation(Required=false)]
        public bool? BackupAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bf-dxrh5jrv0zpb8****</para>
        /// </summary>
        [NameInMap("BackupFileId")]
        [Validation(Required=false)]
        public string BackupFileId { get; set; }

        [NameInMap("BackupFileName")]
        [Validation(Required=false)]
        public string BackupFileName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-05-20 10:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-fxdx91jsfyiy3****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-05-23 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
