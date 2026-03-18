// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeBackupsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>bt-2389hsdui12m</para>
        /// </summary>
        [NameInMap("BackupTaskId")]
        [Validation(Required=false)]
        public string BackupTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1747728000</para>
        /// </summary>
        [NameInMap("TimePeriodEndTime")]
        [Validation(Required=false)]
        public long? TimePeriodEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1747708000</para>
        /// </summary>
        [NameInMap("TimePeriodStartTime")]
        [Validation(Required=false)]
        public long? TimePeriodStartTime { get; set; }

    }

}
