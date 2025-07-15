// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The result description.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, ok is returned.</description></item>
        /// <item><description>If the request failed, the failure detail is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3be7ade8-d907-483c-b24a-0dad4595beaf</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ok: The request was successful.</description></item>
        /// <item><description>fail: The request failed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If any parameter failed to be configured, the request failed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
