// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the queried host accounts.</para>
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForUserGroupResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForUserGroupResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// <para>The ID of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// <para>The name of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host１</para>
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the host for which the host accounts were queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>１</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>Indicates whether the user group is authorized to manage the host account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAuthorized")]
            [Validation(Required=false)]
            public bool? IsAuthorized { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SSH</b></description></item>
            /// <item><description><b>RDP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of host accounts that were queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
