// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Indicates whether another page of results is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of IPs.</para>
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DedicatedIpListResponseBodyIps> Ips { get; set; }
        public class DedicatedIpListResponseBodyIps : TeaModel {
            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-12T09:19:20Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The ID of the IP address, which is the same as the ID of the purchased instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the purchased instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Extended properties.</para>
            /// </summary>
            [NameInMap("IpExt")]
            [Validation(Required=false)]
            public DedicatedIpListResponseBodyIpsIpExt IpExt { get; set; }
            public class DedicatedIpListResponseBodyIpsIpExt : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>Indicates whether an email has been sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasSendMail")]
                [Validation(Required=false)]
                public bool? HasSendMail { get; set; }

                /// <summary>
                /// <para>The last time the warm-up status changed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-07T07:23:49.329Z</para>
                /// </summary>
                [NameInMap("LastWarmUpTypeChangedTime")]
                [Validation(Required=false)]
                public string LastWarmUpTypeChangedTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the IP pool to which the IP belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("IpPoolName")]
            [Validation(Required=false)]
            public string IpPoolName { get; set; }

            /// <summary>
            /// <para>The time when the IP was purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-12T09:19:20Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sold</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The warm-up status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("WarmupStatus")]
            [Validation(Required=false)]
            public string WarmupStatus { get; set; }

            /// <summary>
            /// <para>The warm-up method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cusSelfManager</para>
            /// </summary>
            [NameInMap("WarmupType")]
            [Validation(Required=false)]
            public string WarmupType { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the IP address is located.</para>
            /// <list type="bullet">
            /// <item><description><para>ap-southeast-1a</para>
            /// </description></item>
            /// <item><description><para>ap-southeast-1b</para>
            /// </description></item>
            /// <item><description><para>cn-hangzhou-k</para>
            /// </description></item>
            /// <item><description><para>cn-shanghai-l</para>
            /// </description></item>
            /// <item><description><para>eu-central-1a</para>
            /// </description></item>
            /// <item><description><para>eu-central-1b</para>
            /// </description></item>
            /// <item><description><para>us-east-1a</para>
            /// </description></item>
            /// <item><description><para>us-east-1b</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of purchased IPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
