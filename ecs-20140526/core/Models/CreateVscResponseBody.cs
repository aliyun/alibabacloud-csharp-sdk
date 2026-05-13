// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateVscResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DD38F-12VBW2-**EKX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsc-b*d31dq</para>
        /// </summary>
        [NameInMap("VscId")]
        [Validation(Required=false)]
        public string VscId { get; set; }

    }

}
