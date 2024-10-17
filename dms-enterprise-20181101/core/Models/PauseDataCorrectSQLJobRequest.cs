// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class PauseDataCorrectSQLJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SQL task. You can call the <a href="https://help.aliyun.com/document_detail/208481.html">GetDataCorrectTaskDetail</a> or <a href="https://help.aliyun.com/document_detail/207049.html">ListDBTaskSQLJob</a> operation to obtain the value of this parameter.</para>
        /// <remarks>
        /// <para> If Type is set to SINGLE, you must pass in the value of JobId to confirm the ID of the SQL task that you want to pause.</para>
        /// </remarks>
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
        /// <para>43253</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4325</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The type of the pause operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: pauses all SQL tasks.</description></item>
        /// <item><description>SINGLE: pauses a single SQL task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SINGLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
