// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetAdUsersCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AdUserCount")]
        [Validation(Required=false)]
        public int? AdUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
