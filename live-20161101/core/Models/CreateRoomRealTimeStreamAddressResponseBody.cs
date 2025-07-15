// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRoomRealTimeStreamAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8DB7E25-6A35-161A-AA41-B7A658AF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The RTMP ingest URL.</para>
        /// </summary>
        [NameInMap("RtmpAddress")]
        [Validation(Required=false)]
        public string RtmpAddress { get; set; }

    }

}
