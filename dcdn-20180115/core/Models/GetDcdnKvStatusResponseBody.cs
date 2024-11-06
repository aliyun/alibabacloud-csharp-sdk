// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class GetDcdnKvStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether the configured key has taken effect on all points of presence (POPs).</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// <para>The timeout period of the configured key. The value is an absolute timestamp, such as 2023-09-11T15:39:44+08:00. This parameter is not returned if the key is permanently stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-11T15:39:44+08:00</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
