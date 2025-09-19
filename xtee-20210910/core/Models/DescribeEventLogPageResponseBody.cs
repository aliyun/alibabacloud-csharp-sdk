// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventLogPageResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeEventLogPageResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeEventLogPageResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631801314885832</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Email.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@123.com">xxxx@123.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.200.5.100</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13817606333</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>Nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>昵称</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>Request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>546F8063-0104-5271-9EB7-56FB3F375BAD</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>Score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// <para>Event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册事件</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>Tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm0102</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>Transaction time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737101348000</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4239</para>
            /// </summary>
            [NameInMap("umid")]
            [Validation(Required=false)]
            public string Umid { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
