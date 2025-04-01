// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteIngressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the routing rule that you want to delete. You can call the <a href="https://help.aliyun.com/document_detail/153934.html">ListIngresses</a> operation to obtain the ID of a routing rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("IngressId")]
        [Validation(Required=false)]
        public long? IngressId { get; set; }

    }

}
