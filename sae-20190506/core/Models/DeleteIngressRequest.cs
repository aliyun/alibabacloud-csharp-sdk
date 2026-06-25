// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteIngressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the routing rule to delete. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/153934.html">ListIngresses</a> operation.</para>
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
