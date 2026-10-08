// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page cursor.</para>
        /// </summary>
        [NameInMap("CurrentPageCursor")]
        [Validation(Required=false)]
        public QueryTaskDetailHistoryResponseBodyCurrentPageCursor CurrentPageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyCurrentPageCursor : TeaModel {
            /// <summary>
            /// <para>Job Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Result of task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>执行成功</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Domain instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S1234456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Task detail ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-2342</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <para>Job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution.  </description></item>
            /// <item><description><b>EXECUTING</b>: Executing.  </description></item>
            /// <item><description><b>EXECUTE_SUCCESS</b>: Execution succeeded.  </description></item>
            /// <item><description><b>EXECUTE_FAILURE</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTE_SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Job Status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Waiting to execute.  </description></item>
            /// <item><description><b>1</b>: Executing.  </description></item>
            /// <item><description><b>2</b>: Succeeded.  </description></item>
            /// <item><description><b>3</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Task Type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information.  </description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS.  </description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection.  </description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrative contact information.  </description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information.  </description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information.  </description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name edit lock.  </description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock.  </description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order.  </description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order.  </description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order.  </description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host.  </description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host.  </description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize a DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Description of the task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

            /// <summary>
            /// <para>Retry Count of job details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <para>The most recent task execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Cursor for the next page.</para>
        /// </summary>
        [NameInMap("NextPageCursor")]
        [Validation(Required=false)]
        public QueryTaskDetailHistoryResponseBodyNextPageCursor NextPageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyNextPageCursor : TeaModel {
            /// <summary>
            /// <para>Creation time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Result of task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>域名有禁止更新锁</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Domain name instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S1234567890</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Task detail number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-2424</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <para>Job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution.</description></item>
            /// <item><description><b>EXECUTING</b>: Executing.</description></item>
            /// <item><description><b>EXECUTE_SUCCESS</b>: Succeeded.</description></item>
            /// <item><description><b>EXECUTE_FAILURE</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Task status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Waiting for execution.</description></item>
            /// <item><description><b>1</b>: Executing.</description></item>
            /// <item><description><b>2</b>: Succeeded.</description></item>
            /// <item><description><b>3</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Task Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information.</description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS.</description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection.</description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrator contact information.</description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information.</description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information.</description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable Edit Lock.</description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable transfer lock.</description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order.</description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order.</description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order.</description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host.</description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host.</description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize a DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Task Type Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

            /// <summary>
            /// <para>Number of retries for the task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <para>The most recent running time of the job details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Task detail information.</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<QueryTaskDetailHistoryResponseBodyObjects> Objects { get; set; }
        public class QueryTaskDetailHistoryResponseBodyObjects : TeaModel {
            /// <summary>
            /// <para>The creation time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The result of the job execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>域名有禁止更新锁</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The instance ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S123456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Task detail number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-4234</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <para>The job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution.  </description></item>
            /// <item><description><b>EXECUTING</b>: Executing.  </description></item>
            /// <item><description><b>EXECUTE_SUCCESS</b>: Execution succeeded.  </description></item>
            /// <item><description><b>EXECUTE_FAILURE</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The job status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Waiting for execution.</description></item>
            /// <item><description><b>1</b>: Executing.</description></item>
            /// <item><description><b>2</b>: Succeeded.</description></item>
            /// <item><description><b>3</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information.</description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS settings.</description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection.</description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Update administrative contact information.</description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Update billing contact information.</description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Update technical contact information.</description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable the Edit Lock for the domain name.</description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable the transfer lock for the domain name.</description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order.</description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order.</description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order.</description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host.</description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host.</description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize a DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Task Type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

            /// <summary>
            /// <para>Number of retries for the task detail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <para>The running time of the most recent job execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Paging size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Cursor for the previous page.</para>
        /// </summary>
        [NameInMap("PrePageCursor")]
        [Validation(Required=false)]
        public QueryTaskDetailHistoryResponseBodyPrePageCursor PrePageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyPrePageCursor : TeaModel {
            /// <summary>
            /// <para>Task creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Result of task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>域名有禁止更新锁</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Domain instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S123456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Task detail number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-123</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <para>Task number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution.</description></item>
            /// <item><description><b>EXECUTING</b>: Executing.</description></item>
            /// <item><description><b>EXECUTE_SUCCESS</b>: Execution succeeded.</description></item>
            /// <item><description><b>EXECUTE_FAILURE</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Task status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Waiting for execution.  </description></item>
            /// <item><description><b>1</b>: Executing.  </description></item>
            /// <item><description><b>2</b>: Execution succeeded.  </description></item>
            /// <item><description><b>3</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Task Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information.</description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS.</description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection.</description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrative contact information.</description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information.</description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information.</description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name edit lock.</description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock.</description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order.</description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order.</description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order.</description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host.</description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host.</description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize a DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Description of the task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

            /// <summary>
            /// <para>Number of retries for the task detail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <para>The most recent running time of the task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Unique Request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>548CAE74-88F8-402F-8C12-97E747389C51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
