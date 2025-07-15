// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeLogAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status. <b>true</b>: authorized <b>false</b>: not authorized</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthorizedStatus")]
        [Validation(Required=false)]
        public string AuthorizedStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
