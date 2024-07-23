// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class RegisterCustomViewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomViewId")]
        [Validation(Required=false)]
        public string CustomViewId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>580e8ce3-3b80-44c5-9f3f-36ac3cc5bdd5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
