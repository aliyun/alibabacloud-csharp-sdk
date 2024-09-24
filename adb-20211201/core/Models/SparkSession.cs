// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkSession : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public string Active { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11123123</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public long? AliyunUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>idle</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
