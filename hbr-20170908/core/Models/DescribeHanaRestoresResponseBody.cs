// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaRestoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HanaRestore")]
        [Validation(Required=false)]
        public DescribeHanaRestoresResponseBodyHanaRestore HanaRestore { get; set; }
        public class DescribeHanaRestoresResponseBodyHanaRestore : TeaModel {
            [NameInMap("HanaRestores")]
            [Validation(Required=false)]
            public List<DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores> HanaRestores { get; set; }
            public class DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores : TeaModel {
                [NameInMap("BackupID")]
                [Validation(Required=false)]
                public long? BackupID { get; set; }

                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                [NameInMap("CheckAccess")]
                [Validation(Required=false)]
                public bool? CheckAccess { get; set; }

                [NameInMap("ClearLog")]
                [Validation(Required=false)]
                public bool? ClearLog { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CurrentPhase")]
                [Validation(Required=false)]
                public int? CurrentPhase { get; set; }

                [NameInMap("CurrentProgress")]
                [Validation(Required=false)]
                public long? CurrentProgress { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("DatabaseRestoreId")]
                [Validation(Required=false)]
                public long? DatabaseRestoreId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("LogPosition")]
                [Validation(Required=false)]
                public long? LogPosition { get; set; }

                [NameInMap("MaxPhase")]
                [Validation(Required=false)]
                public int? MaxPhase { get; set; }

                [NameInMap("MaxProgress")]
                [Validation(Required=false)]
                public long? MaxProgress { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                [NameInMap("ReachedTime")]
                [Validation(Required=false)]
                public long? ReachedTime { get; set; }

                [NameInMap("RecoveryPointInTime")]
                [Validation(Required=false)]
                public long? RecoveryPointInTime { get; set; }

                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SourceClusterId")]
                [Validation(Required=false)]
                public string SourceClusterId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SystemCopy")]
                [Validation(Required=false)]
                public bool? SystemCopy { get; set; }

                [NameInMap("UseCatalog")]
                [Validation(Required=false)]
                public bool? UseCatalog { get; set; }

                [NameInMap("UseDelta")]
                [Validation(Required=false)]
                public bool? UseDelta { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public int? VolumeId { get; set; }

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
        /// <para>7DEFC897-8F05-5C05-912C-C9A9510FBFF1</para>
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
        /// <para>19</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
