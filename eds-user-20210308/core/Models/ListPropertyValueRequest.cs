// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyValueRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the property. You can call the <a href="https://help.aliyun.com/document_detail/410890.html">ListProperty</a> operation to query the property ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390</para>
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

    }

}
