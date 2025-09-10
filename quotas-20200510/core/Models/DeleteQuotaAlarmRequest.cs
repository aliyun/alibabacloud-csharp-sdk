// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class DeleteQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota alert.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a> operation to obtain the ID of a quota alert.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b512ab7-da3a-4142-b529-2b2a9294****</para>
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

    }

}
