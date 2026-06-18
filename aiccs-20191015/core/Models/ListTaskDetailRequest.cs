// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The callee number. You can view the callee number on the <b>Detail</b> interface of <a href="https://aiccs.console.aliyun.com/job/list"><b>Task Management</b></a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****0000</para>
        /// </summary>
        [NameInMap("Called")]
        [Validation(Required=false)]
        public string Called { get; set; }

        /// <summary>
        /// <para>The detail ID. You can view the detail ID on the <b>Detail</b> interface of <a href="https://aiccs.console.aliyun.com/job/list"><b>Task Management</b></a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Detail status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SUCCESS</b>: The outbound call succeeded.</description></item>
        /// <item><description><b>FAIL</b>: The outbound call failed.</description></item>
        /// <item><description><b>INIT</b>: The outbound call has not been made.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call Status Codes</a> in Voice Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200100</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The job ID. You can view the job ID on the <a href="https://aiccs.console.aliyun.com/job/list">Task Management</a> page or obtain it by using the <a href="https://help.aliyun.com/document_detail/2718008.html">ListTask</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
