// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkCodeLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <para>stdout:n++++++++++++++++++executing sql: MSCK REPAIR TABLE  <c>footprint_ethereum</c>.<c>dwd_eth_eth_txr_v2_di</c> n++n</para>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public string Log { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>Success</b> is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CD65640-9963-5D60-929C-118F2C84070E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
