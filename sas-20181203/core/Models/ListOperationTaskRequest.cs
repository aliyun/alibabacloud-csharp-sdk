// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> API to obtain the check item ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The page number to display in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Set the language type for the request and response messages. The default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The instance information of the operation tasks to be queried.</para>
        /// </summary>
        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<ListOperationTaskRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class ListOperationTaskRequestOperationTaskInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-bp1vy2yaj1nvx****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Cloud asset vendor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of items to display per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of task statuses. Multiple statuses should be separated by commas (,). Values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: Initialization</description></item>
        /// <item><description><b>FAIL</b>: Processing failed</description></item>
        /// <item><description><b>THROTTLING</b>: Repairing concurrently</description></item>
        /// <item><description><b>IN_BACKUP</b>: Backing up</description></item>
        /// <item><description><b>BACKED_UP</b>: Backed up</description></item>
        /// <item><description><b>BACKUP_FAIL</b>: Backup failed</description></item>
        /// <item><description><b>REPAIRING</b>: Repairing</description></item>
        /// <item><description><b>REPAIR_SUCCESS</b>: Repair succeeded</description></item>
        /// <item><description><b>REPAIR_FAIL</b>: Repair failed</description></item>
        /// <item><description><b>REPAIR_SUCCESS_VERIFYING</b>: Verifying repair success</description></item>
        /// <item><description><b>REPAIR_SUCCESS_UNVERIFIED</b>: Repair success verification failed</description></item>
        /// <item><description><b>REPAIR_SUCCESS_VERIFIED</b>: Repair success verified</description></item>
        /// <item><description><b>REPAIR_RE_EXECUTE</b>: Re-executing repair</description></item>
        /// <item><description><b>ROLL_BACKING</b>: Rolling back</description></item>
        /// <item><description><b>ROLL_BACKED</b>: Rolled back</description></item>
        /// <item><description><b>ROLL_BACK_FAIL</b>: Rollback failed</description></item>
        /// <item><description><b>ROLL_BACK_INIT</b>: Rollback initiated</description></item>
        /// <item><description><b>ROLL_BACK_VERIFYING</b>: Verifying rollback success</description></item>
        /// <item><description><b>ROLL_BACK_UNVERIFIED</b>: Rollback success verification failed</description></item>
        /// <item><description><b>ROLL_BACK_VERIFIED</b>: Rollback success verified</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>The ID of the task to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d7b2acf8d362742123e4a84e1bf8****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of operation task to be queried:</para>
        /// <list type="bullet">
        /// <item><description>REPAIR: Repair</description></item>
        /// <item><description>ROLLBACK: Rollback</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REPAIR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
