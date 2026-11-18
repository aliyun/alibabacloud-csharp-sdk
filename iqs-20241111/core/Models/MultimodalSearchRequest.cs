// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MultimodalSearchRequest : TeaModel {
        /// <summary>
        /// <para>The query parameters and blocked site parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MultimodalSearchBody Body { get; set; }

    }

}
