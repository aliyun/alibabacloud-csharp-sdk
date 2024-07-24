// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeDiskWarningLineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>08DF8283-D290-4107-931E-7913D6D3480D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("WarningLine")]
        [Validation(Required=false)]
        public string WarningLine { get; set; }

    }

}
