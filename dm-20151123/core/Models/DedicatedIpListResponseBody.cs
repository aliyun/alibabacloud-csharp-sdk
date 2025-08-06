// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Whether there is a next page</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>IP list</para>
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DedicatedIpListResponseBodyIps> Ips { get; set; }
        public class DedicatedIpListResponseBodyIps : TeaModel {
            /// <summary>
            /// <para>Expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-12T09:19:20Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>IP ID, consistent with the purchased instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Purchased instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>IP address</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Extended information</para>
            /// </summary>
            [NameInMap("IpExt")]
            [Validation(Required=false)]
            public DedicatedIpListResponseBodyIpsIpExt IpExt { get; set; }
            public class DedicatedIpListResponseBodyIpsIpExt : TeaModel {
                /// <summary>
                /// <para>Whether auto-renewal is enabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>Whether an email has been sent</para>
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
            /// <para>Name of the IP pool</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("IpPoolName")]
            [Validation(Required=false)]
            public string IpPoolName { get; set; }

            /// <summary>
            /// <para>Purchase time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-12T09:19:20Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>IP status</para>
            /// 
            /// <b>Example:</b>
            /// <para>sold</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Warm-up status</para>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("WarmupStatus")]
            [Validation(Required=false)]
            public string WarmupStatus { get; set; }

            /// <summary>
            /// <para>Warm-up method</para>
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
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total amount of purchased IP data</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
