// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsNamedQueryEntry : TeaModel {
        /// <summary>
        /// <para>The end offset of the time range. This parameter is mutually exclusive with window.</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The SPL query expression.</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The start offset of the time range. This parameter is mutually exclusive with window.</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The time unit. Valid values: day, hour, minute, and second.</para>
        /// </summary>
        [NameInMap("timeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// <para>The snap window size. This parameter is mutually exclusive with start and end.</para>
        /// </summary>
        [NameInMap("window")]
        [Validation(Required=false)]
        public long? Window { get; set; }

    }

}
