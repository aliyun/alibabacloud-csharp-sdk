// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamAuthCheckingResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message returned if authentication failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID AUTH_KEY</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16F08B4E-14FD-5D72-AB2F-BAFA4C4D57F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the authentication is passed.</para>
        /// <list type="bullet">
        /// <item><description><para>pass: The authentication is passed.</para>
        /// </description></item>
        /// <item><description><para>false: The authentication failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
