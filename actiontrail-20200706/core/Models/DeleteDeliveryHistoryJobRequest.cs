// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DeleteDeliveryHistoryJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the historical event delivery task to be deleted.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188101.html">ListDeliveryHistoryJobs</a> operation to query task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16602</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

    }

}
