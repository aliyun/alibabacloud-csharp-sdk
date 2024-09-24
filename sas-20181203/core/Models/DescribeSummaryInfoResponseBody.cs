// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of unprotected assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AegisClientOfflineCount")]
        [Validation(Required=false)]
        public int? AegisClientOfflineCount { get; set; }

        /// <summary>
        /// <para>The number of protected assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127</para>
        /// </summary>
        [NameInMap("AegisClientOnlineCount")]
        [Validation(Required=false)]
        public int? AegisClientOnlineCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D40198E1-6EA8-482E-B3C7-D9573D75C0CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security score of the assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>95 to 100: The assets are secure.</description></item>
        /// <item><description>85 to 94: The assets are exposed to a few security risks. We recommend that you reinforce your security system in a timely manner.</description></item>
        /// <item><description>70 to 84: The assets are exposed to multiple security risks. We recommend that you reinforce your security system in a timely manner.</description></item>
        /// <item><description>69 or lower: The current security system is unable to protect the assets against intrusions. We recommend that you reinforce your security system at the earliest opportunity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("SecurityScore")]
        [Validation(Required=false)]
        public int? SecurityScore { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
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
