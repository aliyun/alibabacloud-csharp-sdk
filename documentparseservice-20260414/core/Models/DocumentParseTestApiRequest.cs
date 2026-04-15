// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DocumentParseService20260414.Models
{
    public class DocumentParseTestApiRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/tfs/TB1x2xCAxz1gK0jSZSgXXavwpXa-3541-662.png">https://img.alicdn.com/tfs/TB1x2xCAxz1gK0jSZSgXXavwpXa-3541-662.png</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MAIN_FLOW</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
