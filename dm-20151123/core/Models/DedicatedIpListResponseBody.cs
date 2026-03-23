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
        /// <para>Indicates whether the next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of IP addresses.</para>
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
            /// <para>The IP address ID. This is the same as the purchased instance ID.</para>
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
            /// <para>The extended information.</para>
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
                /// <para>Indicates whether emails have been sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasSendMail")]
                [Validation(Required=false)]
                public bool? HasSendMail { get; set; }

                [NameInMap("LastWarmUpTypeChangedTime")]
                [Validation(Required=false)]
                public string LastWarmUpTypeChangedTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the IP pool to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("IpPoolName")]
            [Validation(Required=false)]
            public string IpPoolName { get; set; }

            /// <summary>
            /// <para>The purchase time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-12T09:19:20Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sold</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The prefetch status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("WarmupStatus")]
            [Validation(Required=false)]
            public string WarmupStatus { get; set; }

            /// <summary>
            /// <para>The prefetch method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cusSelfManager</para>
            /// </summary>
            [NameInMap("WarmupType")]
            [Validation(Required=false)]
            public string WarmupType { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of purchased IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
