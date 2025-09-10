// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota alert.</para>
        /// <para>For more information about how to query the ID of a quota alert, see <a href="https://help.aliyun.com/document_detail/184348.html">ListQuotaAlarms</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78d7e436-4b25-4897-84b5-d7b656bb****</para>
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

    }

}
