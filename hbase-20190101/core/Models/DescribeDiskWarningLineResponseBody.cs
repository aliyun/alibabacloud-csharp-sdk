// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeDiskWarningLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08DF8283-D290-4107-931E-7913D6D3480D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The disk capacity alert threshold. For example, if the value is 75, an alert is triggered when disk usage exceeds 75%. If no value is returned, the user has not configured this parameter, and the system default value is 80%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("WarningLine")]
        [Validation(Required=false)]
        public string WarningLine { get; set; }

    }

}
