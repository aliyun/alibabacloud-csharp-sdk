// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAttackerPortraitResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code that is returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the attacker profile.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotAttackerPortraitResponseBodyList> List { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AttackCount")]
            [Validation(Required=false)]
            public int? AttackCount { get; set; }

            /// <summary>
            /// <para>The information about the browsers of the attack source.</para>
            /// </summary>
            [NameInMap("Browser")]
            [Validation(Required=false)]
            public List<string> Browser { get; set; }

            /// <summary>
            /// <para>The information about the hosts of the attack source.</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<string> Host { get; set; }

            /// <summary>
            /// <para>The timestamp at which the attack was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679896965</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The network information about the attack source.</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public ListHoneypotAttackerPortraitResponseBodyListNetwork Network { get; set; }
            public class ListHoneypotAttackerPortraitResponseBodyListNetwork : TeaModel {
                /// <summary>
                /// <para>The public IP addresses.</para>
                /// </summary>
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public List<string> ExternalIp { get; set; }

                /// <summary>
                /// <para>The private IP addresses.</para>
                /// </summary>
                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public List<string> InternalIp { get; set; }

                /// <summary>
                /// <para>The originating IP addresses.</para>
                /// </summary>
                [NameInMap("RealIp")]
                [Validation(Required=false)]
                public List<string> RealIp { get; set; }

            }

            /// <summary>
            /// <para>The attacker profile ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd48604a-1694-4f03-ade0-ec6994c3****</para>
            /// </summary>
            [NameInMap("PortraitId")]
            [Validation(Required=false)]
            public string PortraitId { get; set; }

            /// <summary>
            /// <para>The social information about the attack source.</para>
            /// </summary>
            [NameInMap("Social")]
            [Validation(Required=false)]
            public List<string> Social { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAttackerPortraitResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A5A2DA6-67EA-5968-960F-6B20FD0C*****</para>
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
