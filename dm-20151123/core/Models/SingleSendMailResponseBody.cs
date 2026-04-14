// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SingleSendMailResponseBody : TeaModel {
        /// <summary>
        /// <para>Event ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>600000xxxxxxxxxx642</para>
        /// </summary>
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D086F6-xxxx-xxxx-xxxx-006DED011A85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
