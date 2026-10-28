// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class DeleteQuotaAlarmRequest : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the quota alert.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the ID of a quota alert, see <a href="https://help.aliyun.com/document_detail/440561.html">ListQuotaAlarms</a>.</para>
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

