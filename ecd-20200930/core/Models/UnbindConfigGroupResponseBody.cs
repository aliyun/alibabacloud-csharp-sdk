// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UnbindConfigGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the configuration groups.</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD0FF13D-FC7D-56AD-934F-91C8487*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
