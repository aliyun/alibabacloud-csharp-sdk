// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PublishRoutineCodeRevisionResponseBody : TeaModel {
        /// <summary>
        /// <para>The version of the routine code that is published to the specified environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;CodeRevision&quot;: &quot;1620876959997924701&quot;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A513734D-D17B-411E-864D-XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
