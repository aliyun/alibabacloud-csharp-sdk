// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed instance information list of operation tasks.</para>
        /// </summary>
        [NameInMap("OperationTasks")]
        [Validation(Required=false)]
        public List<ListOperationTaskResponseBodyOperationTasks> OperationTasks { get; set; }
        public class ListOperationTaskResponseBodyOperationTasks : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>开启恶意主机行为防御功能</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The processing time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723173101010</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BackUpScriptError</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backUp script error</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Whether the instance is released:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Released</para>
            /// </description></item>
            /// <item><description><para>false: Not released</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InstanceFreed")]
            [Validation(Required=false)]
            public bool? InstanceFreed { get; set; }

            /// <summary>
            /// <para>The ID of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9abo6wgjmh4yep****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest check, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723173101000</para>
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public long? LastCheckTime { get; set; }

            /// <summary>
            /// <para>The ID of the region where the server is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of repair supported by the check item:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>:Supports repair and rollback operations</para>
            /// </description></item>
            /// <item><description><para><b>2</b>:Supports repair but not rollback</para>
            /// </description></item>
            /// <item><description><para><b>3</b>:Redirect to a third-party platform for operation</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepairSupportType")]
            [Validation(Required=false)]
            public int? RepairSupportType { get; set; }

            /// <summary>
            /// <para>The risk level of the detected alert. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: High risk.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium risk.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: Low risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The ID of the main task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01db51b0e5307bb703a22611c86f****</para>
            /// </summary>
            [NameInMap("RootTaskId")]
            [Validation(Required=false)]
            public string RootTaskId { get; set; }

            /// <summary>
            /// <para>The status of the task. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INIT</b>:Initialization</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>:Processing failed</para>
            /// </description></item>
            /// <item><description><para><b>THROTTLING</b>:Repairing concurrently</para>
            /// </description></item>
            /// <item><description><para><b>IN_BACKUP</b>:Backing up</para>
            /// </description></item>
            /// <item><description><para><b>BACKED_UP</b>:Backed up</para>
            /// </description></item>
            /// <item><description><para><b>BACKUP_FAIL</b>:Backup failed</para>
            /// </description></item>
            /// <item><description><para><b>REPAIRING</b>:Repairing</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_SUCCESS</b>:Repair succeeded</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_FAIL</b>:Repair failed</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_SUCCESS_VERIFYING</b>:Verifying repair success</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_SUCCESS_UNVERIFIED</b>:Verification of repair success failed</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_SUCCESS_VERIFIED</b>:Verification of repair success succeeded</para>
            /// </description></item>
            /// <item><description><para><b>REPAIR_RE_EXECUTE</b>:Re-executing repair</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACKING</b>:Rolling back</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACKED</b>:Rolled back</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACK_FAIL</b>:Rollback failed</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACK_INIT</b>:Initiating rollback</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACK_VERIFYING</b>:Verifying rollback success</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACK_UNVERIFIED</b>:Verification of rollback success failed</para>
            /// </description></item>
            /// <item><description><para><b>ROLL_BACK_VERIFIED</b>:Verification of rollback success succeeded</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REPAIRING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The display status of the repair task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>回滚已验证</para>
            /// </summary>
            [NameInMap("StatusShowName")]
            [Validation(Required=false)]
            public string StatusShowName { get; set; }

            /// <summary>
            /// <para>Whether rollback is supported:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Supported</para>
            /// </description></item>
            /// <item><description><para>false: Not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportRollBack")]
            [Validation(Required=false)]
            public bool? SupportRollBack { get; set; }

            /// <summary>
            /// <para>The ID of the operation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5bb1a313f9924b728b3c12e007c1****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the operation task being queried:</para>
            /// <list type="bullet">
            /// <item><description><para>REPAIR: Repair</para>
            /// </description></item>
            /// <item><description><para>ROLLBACK: Rollback</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REPAIR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Page information when performing a paginated query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOperationTaskResponseBodyPageInfo PageInfo { get; set; }
        public class ListOperationTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of items to display per page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request, which is a unique identifier generated by Alibaba Cloud for this request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
