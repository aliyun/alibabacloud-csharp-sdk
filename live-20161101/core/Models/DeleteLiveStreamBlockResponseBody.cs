// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the request. A value of ok indicates that the request was successful. An error message is returned if the request failed.</para>
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
        /// <para>B908FF89-B03C-4831-B55B-48D2A7DA0A68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ok: Success.</para>
        /// </description></item>
        /// <item><description><para>fail: Failure.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The status is ok only if all tasks succeeded.</para>
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
