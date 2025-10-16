// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateNatFirewallPreCheckResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2122</para>
        /// </summary>
        [NameInMap("PreCheckId")]
        [Validation(Required=false)]
        public string PreCheckId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A426611F-04FA-5205-8D04-4F6DCF09****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
