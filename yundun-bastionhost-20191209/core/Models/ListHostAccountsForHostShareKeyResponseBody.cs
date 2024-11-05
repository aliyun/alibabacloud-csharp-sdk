// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForHostShareKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the host accounts that are associated with the shared key.</para>
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForHostShareKeyResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForHostShareKeyResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// <para>The name of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root1234</para>
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1113</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The ID of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1235</para>
            /// </summary>
            [NameInMap("HostsAccountId")]
            [Validation(Required=false)]
            public string HostsAccountId { get; set; }

            /// <summary>
            /// <para>The O\&amp;M protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the host accounts that are associated with the shared key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
