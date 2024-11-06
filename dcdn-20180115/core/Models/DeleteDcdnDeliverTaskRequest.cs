// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the tracking tasks that you want to delete. You can call the <a href="https://help.aliyun.com/document_detail/270043.html">DescribeCdnDeliverList</a> operation to query task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

    }

}
