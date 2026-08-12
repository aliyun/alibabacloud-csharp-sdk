// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeBackupsRequest : TeaModel {
        /// <summary>
        /// <para>The backup task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bt-2389hsdui12m</para>
        /// </summary>
        [NameInMap("BackupTaskId")]
        [Validation(Required=false)]
        public string BackupTaskId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The query page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

        /// <summary>
        /// <para>The end time for querying backup jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747728000</para>
        /// </summary>
        [NameInMap("TimePeriodEndTime")]
        [Validation(Required=false)]
        public long? TimePeriodEndTime { get; set; }

        /// <summary>
        /// <para>The start time for querying backup jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747708000</para>
        /// </summary>
        [NameInMap("TimePeriodStartTime")]
        [Validation(Required=false)]
        public long? TimePeriodStartTime { get; set; }

    }

}
