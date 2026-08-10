// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetQpsStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The chart configurations.</para>
        /// </summary>
        [NameInMap("Charts")]
        [Validation(Required=false)]
        public Dictionary<string, ChartsValue> Charts { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. It can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
