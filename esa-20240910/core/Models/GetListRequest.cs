// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom list, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850217.html">ListLists</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
