// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StopRtcAsrTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the request. If success is returned, the request is successful. If an error message is returned, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D208CC1-27C9-51E9-82B8-A6682D466421</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned HTTP status code. HTTP status code 2000 indicates that the request is successful. If another HTTP status code is returned, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public long? RetCode { get; set; }

    }

}
