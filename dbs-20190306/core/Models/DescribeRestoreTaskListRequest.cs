// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <remarks>
        /// <para>Specify either BackupPlanId or RestoreTaskId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0wwwXXXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. This prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361528</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 0 and not exceed the maximum value of the integer data type. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>Default value: 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the restore job. You can specify multiple IDs. Separate them with commas (,). Call the <a href="https://help.aliyun.com/document_detail/2869836.html">CreateRestoreTask</a> operation to obtain this parameter.</para>
        /// <remarks>
        /// <para>Specify either RestoreTaskId or BackupPlanId. An error occurs if you specify both parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s102h7rf5anq</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

        /// <summary>
        /// <para>The start time of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361528</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
