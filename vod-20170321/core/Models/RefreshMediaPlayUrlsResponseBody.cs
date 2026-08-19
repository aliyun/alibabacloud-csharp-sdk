// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of audio or video IDs that are forbidden. This is typically because you do not have multi-application permissions. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a6e49sfgd23p5g9ja7095863****</para>
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public string ForbiddenMediaIds { get; set; }

        /// <summary>
        /// <para>The ID of the refresh or prefetch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41d465e31957****</para>
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

        /// <summary>
        /// <para>The list of audio or video IDs that do not exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b658067095869****</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public string NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-04D5-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
