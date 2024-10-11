// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the auxiliary media assets that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4DF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
