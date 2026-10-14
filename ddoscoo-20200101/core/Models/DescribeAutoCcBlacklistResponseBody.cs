// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcBlacklistResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of blacklisted IP addresses for the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// </summary>
        [NameInMap("AutoCcBlacklist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist> AutoCcBlacklist { get; set; }
        public class DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist : TeaModel {
            /// <summary>
            /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            /// <summary>
            /// <para>The expiration time of the blacklisted IP address. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584093569</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The blacklisted IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The source of the blacklisted IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>manual</b>: The IP address is manually added.</para>
            /// </description></item>
            /// <item><description><para><b>auto</b>: The IP address is automatically added.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E78C8472-0B15-42D5-AF22-A32A78818AB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of blacklisted IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
