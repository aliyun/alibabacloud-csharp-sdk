// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetEntityStoreDataHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gzip</para>
        /// </summary>
        [NameInMap("acceptEncoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
