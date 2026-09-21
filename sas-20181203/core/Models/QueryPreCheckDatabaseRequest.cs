// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the server database backup client.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeUniBackupDatabase~~">DescribeUniBackupDatabase</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>You must specify at least one of TaskId and InstanceUuid. If neither is specified, the API returns HTTP 400 with error code -106.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ebc895506c6911ed800000163e0e****</para>
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// <para>The ID of the database pre-check task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~StartPreCheckDatabase~~">StartPreCheckDatabase</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>You must specify at least one of TaskId and InstanceUuid. If neither is specified, the API returns HTTP 400 with error code -106.</para>
        /// <para>Call DescribeUniBackupDatabase to obtain the InstanceUuid, and then pass it to StartPreCheckDatabase. The CreateMark returned by StartPreCheckDatabase is the TaskId required by this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-000bc9nqwxsbyvod****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The region ID of the database server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

    }

}
