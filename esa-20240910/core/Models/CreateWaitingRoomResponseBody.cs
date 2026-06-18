// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWaitingRoomResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85H66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The waiting room ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8527e8405ac25bfb7fb7ca0d12b0ed83</para>
        /// </summary>
        [NameInMap("WaitingRoomId")]
        [Validation(Required=false)]
        public string WaitingRoomId { get; set; }

    }

}
