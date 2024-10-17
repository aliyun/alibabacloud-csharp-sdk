// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The input URL that you specified for the media asset when you registered the media asset. For more information, see <a href="https://help.aliyun.com/document_detail/441152.html">RegisterMediaInfo</a>.</para>
        /// <remarks>
        /// <para> You must specify at least one of the MediaId and InputURL parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// <remarks>
        /// <para> You must specify at least one of the MediaId and InputURL parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86434e152b7d4f20be480574439fe***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
