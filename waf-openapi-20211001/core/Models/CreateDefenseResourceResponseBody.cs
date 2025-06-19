// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseResourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1738C613-D054-5191-888B-DC0CF4C3A4A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cdX.XXX-call.cn-alb</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
