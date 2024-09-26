// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/173911.html">ListConnection</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public long? ConnectionId { get; set; }

    }

}
