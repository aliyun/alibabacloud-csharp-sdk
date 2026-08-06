// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class SubmitSkillVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The skill version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ba9b5c2466dc408c9fcd9df72bcd762a</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE66410A-37F8-55C5-8471-589CA195760C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
