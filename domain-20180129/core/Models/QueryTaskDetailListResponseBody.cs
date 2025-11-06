// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailListResponseBodyData Data { get; set; }
        public class QueryTaskDetailListResponseBodyData : TeaModel {
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public List<QueryTaskDetailListResponseBodyDataTaskDetail> TaskDetail { get; set; }
            public class QueryTaskDetailListResponseBodyDataTaskDetail : TeaModel {
                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-25 20:46:57</para>
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
                /// <para>The error message returned when the task failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The operation is successful.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The cause of a domain name task failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Purchase record exists for the domain name in Aliyun</para>
                /// </summary>
                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                /// <summary>
                /// <para>The instance ID of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S20179H1BBI9test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the task details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>75addb07-28a3-450e-b5ec-test</para>
                /// </summary>
                [NameInMap("TaskDetailNo")]
                [Validation(Required=false)]
                public string TaskDetailNo { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60d6e201-8ee5-47ab-8fdc-test</para>
                /// </summary>
                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                /// <summary>
                /// <para>The result of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("TaskResult")]
                [Validation(Required=false)]
                public string TaskResult { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>WAITING_EXECUTE</b>: To be executed</description></item>
                /// <item><description><b>EXECUTING</b>: being executed</description></item>
                /// <item><description><b>EXECUTE_SUCCESS</b>: successful</description></item>
                /// <item><description><b>EXECUTE_FAILURE</b>: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EXECUTE_SUCCESS</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <para>The status code of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: waiting for execution</description></item>
                /// <item><description><b>1</b>: being executed</description></item>
                /// <item><description><b>2</b>: successful</description></item>
                /// <item><description><b>3</b>: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TaskStatusCode")]
                [Validation(Required=false)]
                public int? TaskStatusCode { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CHG_HOLDER</b>: The task is run to modify the domain name registrant.</description></item>
                /// <item><description><b>CHG_DNS</b>: The task is run to change the Domain Name System (DNS) servers.</description></item>
                /// <item><description><b>SET_WHOIS_PROTECT</b>: The task is run to configure privacy protection for the domain name.</description></item>
                /// <item><description><b>UPDATE_ADMIN_CONTACT</b>: The task is run to modify the information about the administrator of the domain name.</description></item>
                /// <item><description><b>UPDATE_BILLING_CONTACT</b>: The task is run to modify the information about the payer for the domain name.</description></item>
                /// <item><description><b>UPDATE_TECH_CONTACT</b>: The task is run to modify the information about the technical support for the domain name.</description></item>
                /// <item><description><b>SET_UPDATE_PROHIBITED</b>: The task is run to configure the security lock for the domain name.</description></item>
                /// <item><description><b>SET_TRANSFER_PROHIBITED</b>: The task is run to configure the transfer lock for the domain name.</description></item>
                /// <item><description><b>ORDER_ACTIVATE</b>: The task is run to create a registration order for the domain name.</description></item>
                /// <item><description><b>ORDER_RENEW</b>: The task is run to create a renewal order for the domain name.</description></item>
                /// <item><description><b>ORDER_REDEEM</b>: The task is run to create a redemption order for the domain name.</description></item>
                /// <item><description><b>CREATE_DNSHOST</b>: The task is run to create a DNS server for the domain name.</description></item>
                /// <item><description><b>UPDATE_DNSHOST</b>: The task is run to update the information about a DNS server for the domain name.</description></item>
                /// <item><description><b>SYNC_DNSHOST</b>: The task is run to synchronize a DNS server for the domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORDER_RENEW</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The description of the task type.</para>
                /// </summary>
                [NameInMap("TaskTypeDescription")]
                [Validation(Required=false)]
                public string TaskTypeDescription { get; set; }

                /// <summary>
                /// <para>The number of times the task was retried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TryCount")]
                [Validation(Required=false)]
                public int? TryCount { get; set; }

                /// <summary>
                /// <para>The last time when the task was run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-25 20:47:01</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is preceded by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A2320E4-D870-49C9-A6DC-test</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
