// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAppliedConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the Logtail configurations.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        /// <summary>
        /// <para>The number of Logtail configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
