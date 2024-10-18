// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class DescribeVerifySchemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. OK indicates that the request is successful. For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C5380A7-2032-5F7D-9614-1BF8B54D16CB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("SchemeQueryResultDTO")]
        [Validation(Required=false)]
        public DescribeVerifySchemeResponseBodySchemeQueryResultDTO SchemeQueryResultDTO { get; set; }
        public class DescribeVerifySchemeResponseBodySchemeQueryResultDTO : TeaModel {
            /// <summary>
            /// <para>The key generated when you create a service in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZDMARqPkyQzWVJjB/sB/+fCp5TA4lNsRnY7rEC+HfGsOIOk1Brj8UyXFW2RBYIWqLieCSo8ZypEaEj+h9rLd3FgpXAjGYDfmOperod6jPUUwFHhBObxK+HuKVoi2jOqN7aDOlyPyGcATyq3BDdlf922JmnFLT8Hvnu4qgzzCZk0LXWTb0XVPnm5/fHUGHEA2Q+aTrGkaWcHjmTDqQ7BtvrAIIcJJkCJu4i1aeU++/0EzGWap4mcb2VhKROBs****</para>
            /// </summary>
            [NameInMap("AppEncryptInfo")]
            [Validation(Required=false)]
            public string AppEncryptInfo { get; set; }

        }

    }

}
