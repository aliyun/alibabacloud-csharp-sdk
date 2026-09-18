// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobSanityCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The sequence number of the computing power health check for the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SanityCheckNumber")]
        [Validation(Required=false)]
        public int? SanityCheckNumber { get; set; }

        /// <summary>
        /// <para>The phase of the computing power health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CheckInit: environment preparation check.</description></item>
        /// <item><description>DeviceCheck: single-card computing power check.</description></item>
        /// <item><description>SingleNodeCommCheck: intra-node communication check.</description></item>
        /// <item><description>TwoNodeCommCheck: two-node communication check.</description></item>
        /// <item><description>AllNodeCommCheck: all-node communication check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DeviceCheck</para>
        /// </summary>
        [NameInMap("SanityCheckPhase")]
        [Validation(Required=false)]
        public string SanityCheckPhase { get; set; }

        /// <summary>
        /// <para>The token information in the job sharing token. To obtain the token, see <a href="https://help.aliyun.com/document_detail/2557812.html">GetToken</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbG<b><b><b>zI1NiIsInR5cCI6IkpXVCJ9.eyJle</b></b>jE3MDk1Mzk0NDIsImlhdCI6MTcwODkzNDY0MiwidXNlcl9pZCI6IjE3NTgwNTQxNjI0Mzg2NTUiLCJ0YXJnZXRfaWQiOiJkbGM1OGh1a2xyYzZwdGMyIiwidGFyZ2V0X3R5cGUiOiJqb2IifQ.GNL7jo6</b><b>mgKKv0QeGIYgvBufSU-PH_EQttX</b>**</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
