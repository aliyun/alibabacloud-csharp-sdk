// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ResetConsumeOffsetRequest : TeaModel {
        /// <summary>
        /// <para>The time when the consumer offset is reset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-22 12:17:08</para>
        /// </summary>
        [NameInMap("resetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        /// <summary>
        /// <para>The method that is used to reset the consumer offset. Valid values: LATEST_OFFSET and SPECIFIED_TIME.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST_OFFSET</para>
        /// </summary>
        [NameInMap("resetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
