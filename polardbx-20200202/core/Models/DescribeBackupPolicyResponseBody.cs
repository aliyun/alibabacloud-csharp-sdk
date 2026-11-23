// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyData Data { get; set; }
        public class DescribeBackupPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The backup cycle. You must specify at least 2 days. The value is a 7-digit string. Each digit from left to right indicates whether backup is enabled from Monday to Sunday. A value of 0 indicates that backup is disabled, and a value of 1 indicates that backup is enabled:</para>
            /// <list type="bullet">
            /// <item><description>First digit: Monday</description></item>
            /// <item><description>Second digit: Tuesday</description></item>
            /// <item><description>Third digit: Wednesday</description></item>
            /// <item><description>Fourth digit: Thursday</description></item>
            /// <item><description>Fifth digit: Friday</description></item>
            /// <item><description>Sixth digit: Saturday</description></item>
            /// <item><description>Seventh digit: Sunday</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1001000</para>
            /// </summary>
            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public string BackupPeriod { get; set; }

            /// <summary>
            /// <para>The start time of the daily backup, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03:00Z</para>
            /// </summary>
            [NameInMap("BackupPlanBegin")]
            [Validation(Required=false)]
            public string BackupPlanBegin { get; set; }

            /// <summary>
            /// <para>The retention period of backup sets, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("BackupSetRetention")]
            [Validation(Required=false)]
            public int? BackupSetRetention { get; set; }

            /// <summary>
            /// <para>The backup type. A value of 0 indicates quick backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The backup method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>P</b>: physical backup</description></item>
            /// <item><description><b>L</b>: logical backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>P</para>
            /// </summary>
            [NameInMap("BackupWay")]
            [Validation(Required=false)]
            public string BackupWay { get; set; }

            /// <summary>
            /// <para>The interval for cold data backups, in days. Valid values: 1 to 59.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ColdDataBackupInterval")]
            [Validation(Required=false)]
            public int? ColdDataBackupInterval { get; set; }

            /// <summary>
            /// <para>The retention period of cold data backups, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ColdDataBackupRetention")]
            [Validation(Required=false)]
            public int? ColdDataBackupRetention { get; set; }

            /// <summary>
            /// <para>The retention period of cross-region data backups, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CrossRegionDataBackupRetention")]
            [Validation(Required=false)]
            public int? CrossRegionDataBackupRetention { get; set; }

            /// <summary>
            /// <para>The number of days selected for cross-region backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3,7,1,5,6,2,4</para>
            /// </summary>
            [NameInMap("CrossRegionFilterValue")]
            [Validation(Required=false)]
            public string CrossRegionFilterValue { get; set; }

            /// <summary>
            /// <para>The retention period of cross-region log backups, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CrossRegionLogBackupRetention")]
            [Validation(Required=false)]
            public int? CrossRegionLogBackupRetention { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzjasdyuoo</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The destination region for cross-region backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestCrossRegion")]
            [Validation(Required=false)]
            public string DestCrossRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether binary logs are forcibly cleared when the space usage of the instance is excessively high. A value of 1 indicates yes, and a value of 0 indicates no.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ForceCleanOnHighSpaceUsage")]
            [Validation(Required=false)]
            public int? ForceCleanOnHighSpaceUsage { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-region data backup is enabled. Default value: false.</para>
            /// </summary>
            [NameInMap("IsCrossRegionDataBackupEnabled")]
            [Validation(Required=false)]
            public bool? IsCrossRegionDataBackupEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-region log backup is enabled. Default value: false.</para>
            /// </summary>
            [NameInMap("IsCrossRegionLogBackupEnabled")]
            [Validation(Required=false)]
            public bool? IsCrossRegionLogBackupEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether backup is enabled. The value is fixed as 1, which indicates that backup is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            /// <summary>
            /// <para>The retention period of local log backups, in hours. Valid values: 0 to 7 × 24. A value of 0 indicates that local log backups are not retained. Default value: 7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("LocalLogRetention")]
            [Validation(Required=false)]
            public int? LocalLogRetention { get; set; }

            /// <summary>
            /// <para>The number of local binary logs to retain. Valid values: 6 to 100. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("LocalLogRetentionNumber")]
            [Validation(Required=false)]
            public int? LocalLogRetentionNumber { get; set; }

            /// <summary>
            /// <para>The maximum space usage of binary logs. The parameter value ranges from 0 to 50. This is a loop space. Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogLocalRetentionSpace")]
            [Validation(Required=false)]
            public int? LogLocalRetentionSpace { get; set; }

            /// <summary>
            /// <para>The retention period of remote log backups, in days. Valid values: 7 to 730. Default value: 7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("RemoveLogRetention")]
            [Validation(Required=false)]
            public int? RemoveLogRetention { get; set; }

        }

        /// <summary>
        /// <para>The message returned. If the request is successful, success is returned. If the request fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B87E2AB3-B7C9-4394-9160-7F639F732031</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
