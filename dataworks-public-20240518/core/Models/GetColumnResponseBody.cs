// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetColumnResponseBody : TeaModel {
        [NameInMap("Column")]
        [Validation(Required=false)]
        public Column Column { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D1E2E5BC-xxxx-xxxx-xxxx-xxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
