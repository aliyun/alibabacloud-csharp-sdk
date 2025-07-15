// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveAIStudioResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17D7526C-69AD-5761-8037-071C27358345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual studio template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>369ced1f-c33a-49e5-91da-bdaae3d6c1c2</para>
        /// </summary>
        [NameInMap("StudioId")]
        [Validation(Required=false)]
        public string StudioId { get; set; }

    }

}
