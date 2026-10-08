// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskInfoHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Cursor for the current page.</para>
        /// </summary>
        [NameInMap("CurrentPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyCurrentPageCursor CurrentPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyCurrentPageCursor : TeaModel {
            /// <summary>
            /// <para>User IP address when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <para>Job creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-01 17:22:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Job creation UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509528171000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <para>Job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aa634d3f-927e-4d17-9d2c-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Number of domain names included in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution;</description></item>
            /// <item><description><b>EXECUTING</b>: Executing;</description></item>
            /// <item><description><b>COMPLETE</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Job status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Waiting for execution  </description></item>
            /// <item><description><b>2</b>: Executing  </description></item>
            /// <item><description><b>3</b>: Execution completed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Job type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information  </description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS  </description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection  </description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrator contact information  </description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information  </description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information  </description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name edit lock  </description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock  </description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create registration order  </description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create renewal order  </description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create redemption order  </description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create DNS host  </description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update DNS host  </description></item>
            /// <item><description><b>UPDATE_REGISTRANT_CONTACT</b>: Modify registrant contact  </description></item>
            /// <item><description><b>DELETE_DOMAIN</b>: Delete domain name  </description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize DNS host</description></item>
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

        }

        /// <summary>
        /// <para>Cursor for the next page.</para>
        /// </summary>
        [NameInMap("NextPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyNextPageCursor NextPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyNextPageCursor : TeaModel {
            /// <summary>
            /// <para>User IP address when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <para>Creation Time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-10-27 13:07:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creation Time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509080827000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <para>Job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8f112aa1-98be-48c3-82f8-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Number of domain names included in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting to execute;  </description></item>
            /// <item><description><b>EXECUTING</b>: Executing;  </description></item>
            /// <item><description><b>COMPLETE</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Job status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Waiting to execute;  </description></item>
            /// <item><description><b>2</b>: Executing;  </description></item>
            /// <item><description><b>3</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Task Type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information;  </description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS;  </description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection;  </description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrative contact information;  </description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information;  </description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information;  </description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name Edit Lock;  </description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock;  </description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order;  </description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order;  </description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order;  </description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host;  </description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host;  </description></item>
            /// <item><description><b>UPDATE_REGISTRANT_CONTACT</b>: Modify registrant contact information;  </description></item>
            /// <item><description><b>DELETE_DOMAIN</b>: Delete a domain name;  </description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Task type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

        }

        /// <summary>
        /// <para>Job information.</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<QueryTaskInfoHistoryResponseBodyObjects> Objects { get; set; }
        public class QueryTaskInfoHistoryResponseBodyObjects : TeaModel {
            /// <summary>
            /// <para>User IP address when submitting the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <para>Task creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-01 17:22:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Task creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509528171000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <para>Job number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aa634d3f-927e-4d17-9d2c-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Number of domain names included in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <para>Task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution;</description></item>
            /// <item><description><b>EXECUTING</b>: Executing;</description></item>
            /// <item><description><b>COMPLETE</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Task status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Waiting for execution;</description></item>
            /// <item><description><b>2</b>: Executing;</description></item>
            /// <item><description><b>3</b>: Execution completed.</description></item>
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
            /// <item><description><b>CHG_HOLDER</b>: Modify owner information;</description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS;</description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection;</description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Modify administrative contact information;</description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Modify billing contact information;</description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Modify technical contact information;</description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name edit lock;</description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock;</description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order;</description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order;</description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order;</description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host;</description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host;</description></item>
            /// <item><description><b>UPDATE_REGISTRANT_CONTACT</b>: Modify registrant contact information;</description></item>
            /// <item><description><b>DELETE_DOMAIN</b>: Delete a domain name;</description></item>
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
            /// <para>Task type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

        }

        /// <summary>
        /// <para>Page size.</para>
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
        public QueryTaskInfoHistoryResponseBodyPrePageCursor PrePageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyPrePageCursor : TeaModel {
            /// <summary>
            /// <para>User IP address when submitting the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <para>Job creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-01 17:19:47</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Job creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509527987000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <para>Task number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f9baa3d5-33b9-4c81-8847-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <para>Number of domain names included in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>WAITING_EXECUTE</b>: Waiting for execution;  </description></item>
            /// <item><description><b>EXECUTING</b>: Executing;  </description></item>
            /// <item><description><b>COMPLETE</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Task status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Waiting for execution;  </description></item>
            /// <item><description><b>2</b>: Executing;  </description></item>
            /// <item><description><b>3</b>: Execution completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            /// <summary>
            /// <para>Task Type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>CHG_HOLDER</b>: Modify registrant information;  </description></item>
            /// <item><description><b>CHG_DNS</b>: Modify DNS;  </description></item>
            /// <item><description><b>SET_WHOIS_PROTECT</b>: Enable privacy protection;  </description></item>
            /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: Update administrative contact;  </description></item>
            /// <item><description><b>UPDATE_BILLING_CONTACT</b>: Update billing contact;  </description></item>
            /// <item><description><b>UPDATE_TECH_CONTACT</b>: Update technical contact;  </description></item>
            /// <item><description><b>SET_UPDATE_PROHIBITED</b>: Enable domain name edit lock;  </description></item>
            /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: Enable domain name transfer lock;  </description></item>
            /// <item><description><b>ORDER_ACTIVATE</b>: Create a registration order;  </description></item>
            /// <item><description><b>ORDER_RENEW</b>: Create a renewal order;  </description></item>
            /// <item><description><b>ORDER_REDEEM</b>: Create a redemption order;  </description></item>
            /// <item><description><b>CREATE_DNSHOST</b>: Create a DNS host;  </description></item>
            /// <item><description><b>UPDATE_DNSHOST</b>: Update a DNS host;  </description></item>
            /// <item><description><b>UPDATE_REGISTRANT_CONTACT</b>: Update registrant contact;  </description></item>
            /// <item><description><b>DELETE_DOMAIN</b>: Delete a domain name;  </description></item>
            /// <item><description><b>SYNC_DNSHOST</b>: Synchronize DNS host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHG_DNS</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>Task type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>修改DNS</para>
            /// </summary>
            [NameInMap("TaskTypeDescription")]
            [Validation(Required=false)]
            public string TaskTypeDescription { get; set; }

        }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB3FCCBA-CA1F-4D31-9F34-test</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
