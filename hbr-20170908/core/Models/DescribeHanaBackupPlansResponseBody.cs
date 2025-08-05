// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the backup plan.</para>
        /// </summary>
        [NameInMap("HanaBackupPlans")]
        [Validation(Required=false)]
        public DescribeHanaBackupPlansResponseBodyHanaBackupPlans HanaBackupPlans { get; set; }
        public class DescribeHanaBackupPlansResponseBodyHanaBackupPlans : TeaModel {
            [NameInMap("HanaBackupPlan")]
            [Validation(Required=false)]
            public List<DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan> HanaBackupPlan { get; set; }
            public class DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan : TeaModel {
                /// <summary>
                /// <para>The backup prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE_DATA_BACKUP</para>
                /// </summary>
                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                /// <summary>
                /// <para>The backup type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLETE: full backup</description></item>
                /// <item><description>INCREMENTAL: incremental backup</description></item>
                /// <item><description>DIFFERENTIAL: differential backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The ID of the SAP HANA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-0002scknka*****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEMDB</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup plan is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The backup plan is disabled.</description></item>
                /// <item><description>false: The backup plan is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The ID of the backup plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-0000tnyndg3ne5m4ubeu</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// <para>The name of the backup plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>plan-20220118-141153</para>
                /// </summary>
                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                /// <summary>
                /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
                /// <list type="bullet">
                /// <item><description>startTime: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
                /// <item><description>interval: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>I|1602673264|P1D</para>
                /// </summary>
                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-000csihw82pqkd7hcjws</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F029C1C7-26B6-5ADD-A73E-D85CCD7C73A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
