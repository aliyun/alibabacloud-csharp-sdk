// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetPageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom response page. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/2850223.html">ListPages</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
