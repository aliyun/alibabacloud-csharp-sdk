// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAttackerSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates that the call is successful. Any other value indicates that the call failed. You can troubleshoot the failure based on this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of attack sources.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotAttackerSourceResponseBodyList> List { get; set; }
        public class ListHoneypotAttackerSourceResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The total number of attack events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// <para>The target honeypot of the latest attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc tcp honeypot</para>
            /// </summary>
            [NameInMap("LastTargetHoneypot")]
            [Validation(Required=false)]
            public string LastTargetHoneypot { get; set; }

            /// <summary>
            /// <para>The target IP address of the latest attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144.23.66.***</para>
            /// </summary>
            [NameInMap("LastTargetIp")]
            [Validation(Required=false)]
            public string LastTargetIp { get; set; }

            /// <summary>
            /// <para>The time when the latest attack event occurred. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693446913000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: Low risk.</description></item>
            /// <item><description><b>3</b>: Medium risk.</description></item>
            /// <item><description><b>4</b>: High risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.102.61.***</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        /// <summary>
        /// <para>The message returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAttackerSourceResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAttackerSourceResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned on each page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This ID is generated by Alibaba Cloud and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9915DC4D-B4DA-5140-8138-FD80636*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
