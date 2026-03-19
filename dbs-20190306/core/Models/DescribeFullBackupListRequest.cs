// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeFullBackupListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsr179qz******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1iukx5h******</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("BackupSetStatus")]
        [Validation(Required=false)]
        public string BackupSetStatus { get; set; }

        /// <summary>
        /// <para>A token that ensures idempotence and prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the backup, in UNIX timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676887128</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers from 0 to the maximum integer value. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>30</para>
        /// </description></item>
        /// <item><description><para>50</para>
        /// </description></item>
        /// <item><description><para>100</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowProgress")]
        [Validation(Required=false)]
        public string ShowProgress { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the storage class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowStorageType")]
        [Validation(Required=false)]
        public bool? ShowStorageType { get; set; }

        /// <summary>
        /// <para>The start time of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676887100</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
