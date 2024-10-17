// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeletePlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The URLs of the media streams that cannot be deleted. Generally, media streams cannot be deleted if you do not have the required permissions.</para>
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public List<string> ForbiddenList { get; set; }

        /// <summary>
        /// <para>The URLs of ignored media streams. An error occurred while obtaining such media assets because the IDs or URLs of the media assets do not exist.</para>
        /// </summary>
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
