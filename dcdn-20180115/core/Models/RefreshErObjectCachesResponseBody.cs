// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshErObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the refresh task. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>95248880</para>
        /// </summary>
        [NameInMap("RefreshTaskId")]
        [Validation(Required=false)]
        public string RefreshTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
