// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcBlacklistResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the IP addresses in the blacklist of the instance.</para>
        /// </summary>
        [NameInMap("AutoCcBlacklist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist> AutoCcBlacklist { get; set; }
        public class DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist : TeaModel {
            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            /// <summary>
            /// <para>The validity period of the IP address in the blacklist. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584093569</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The IP address in the blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The mode of how the IP address is added to the blacklist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>manual</b>: manually added</description></item>
            /// <item><description><b>auto</b>: automatically added</description></item>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E78C8472-0B15-42D5-AF22-A32A78818AB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned IP addresses in the blacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
