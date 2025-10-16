// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeClearAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1755964800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("LeftTimes")]
        [Validation(Required=false)]
        public int? LeftTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8DDEE254-5639-5548-82D1-AAAC7347****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
