// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CloneEngineConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EngineConfigId")]
        [Validation(Required=false)]
        public string EngineConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A04CB8C0-E74A-5E83-BC61-64D153574EC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
