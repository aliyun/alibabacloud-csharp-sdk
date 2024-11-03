// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteCdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the tracking task that you want to delete. You can call the <a href="https://help.aliyun.com/document_detail/270877.html">DescribeCdnDeliverList</a> operation to query task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

    }

}
