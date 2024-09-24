// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the agent that is used to back up the data of the database.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeUniBackupDatabase~~">DescribeUniBackupDatabase</a> operation to query the UUID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ebc895506c6911ed800000163e0e****</para>
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// <para>The ID of the database precheck task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~StartPreCheckDatabase~~">StartPreCheckDatabase</a> operation to query the ID of the database precheck task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>t-000bc9nqwxsbyvod****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The region ID of the server that hosts the database.</para>
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
