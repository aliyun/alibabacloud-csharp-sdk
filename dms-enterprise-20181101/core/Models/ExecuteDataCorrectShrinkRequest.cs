// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataCorrectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are required to perform the data change.</para>
        /// <pre><c>
        /// json
        /// &quot;actionDetail&quot; : {
        ///     &quot;startTime&quot; :&quot;2021-07-01 00:00:00&quot;, // Specify the start time to change data. If you want to immediately change data, you do not need to set this parameter. 
        ///     &quot;endTime&quot; : &quot;2021-07-01 01:00:00&quot;, // Specify the end time to change data. If you want to immediately change data, you do not need to set this parameter. 
        ///     &quot;transaction&quot; : false, // Specify whether to change data as a transaction. 
        ///     &quot;backupData&quot; : true // Specify whether to back up data. 
        ///   }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;startTime&quot; : &quot;2021-07-01 00:00:00&quot;, &quot;endTime&quot; : &quot;2021-07-01 01:00:00&quot;, &quot;transaction&quot; : false, &quot;backupData&quot; : true }</para>
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public string ActionDetailShrink { get; set; }

        /// <summary>
        /// <para>The ID of the ticket. You can call the <a href="https://help.aliyun.com/document_detail/144643.html">ListOrders</a> operation to query the ID of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>406****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public string Tid { get; set; }

    }

}
