// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTagKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tag keys.</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public GetTagKeyResponseBodyTagKeys TagKeys { get; set; }
        public class GetTagKeyResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<string> TagKey { get; set; }

        }

    }

}
