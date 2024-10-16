// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Policy : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("outerBizNo")]
        [Validation(Required=false)]
        public string OuterBizNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
