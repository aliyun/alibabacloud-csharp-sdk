// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTagValResponseBody : TeaModel {
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
        /// <para>The tag values.</para>
        /// </summary>
        [NameInMap("TagValues")]
        [Validation(Required=false)]
        public GetTagValResponseBodyTagValues TagValues { get; set; }
        public class GetTagValResponseBodyTagValues : TeaModel {
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public List<string> TagValue { get; set; }

        }

    }

}
