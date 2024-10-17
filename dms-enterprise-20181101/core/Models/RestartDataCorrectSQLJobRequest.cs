// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RestartDataCorrectSQLJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SQL task. You can call the <a href="https://help.aliyun.com/document_detail/208481.html">GetDataCorrectTaskDetail</a> and <a href="https://help.aliyun.com/document_detail/207049.html">ListDBTaskSQLJob</a> operations to obtain the value of this parameter.</para>
        /// <para>If the Type parameter is set to SINGLE, you must pass the value of the JobId parameter to confirm the ID of the SQL task that you want to rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43253</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The ID of the data change ticket. You can call the <a href="https://help.aliyun.com/document_detail/144643.html">ListOrders</a> operation to query the ID of the data change ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>453****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The type of the rerun operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: reruns all SQL tasks.</description></item>
        /// <item><description><b>SINGLE</b>: reruns a single SQL task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
