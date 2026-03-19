// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreRangeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbssl67c7mx****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The start timestamp of the restorable time range. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646674092000</para>
        /// </summary>
        [NameInMap("BeginTimestampForRestore")]
        [Validation(Required=false)]
        public long? BeginTimestampForRestore { get; set; }

        /// <summary>
        /// <para>A client token that ensures the idempotence of requests and prevents duplicate submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end timestamp of the restorable time range. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646846814000</para>
        /// </summary>
        [NameInMap("EndTimestampForRestore")]
        [Validation(Required=false)]
        public long? EndTimestampForRestore { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>Whether to enable recent restore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecentlyRestore")]
        [Validation(Required=false)]
        public bool? RecentlyRestore { get; set; }

    }

}
