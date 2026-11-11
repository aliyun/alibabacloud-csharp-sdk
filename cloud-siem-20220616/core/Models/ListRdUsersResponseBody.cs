// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListRdUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRdUsersResponseBodyData> Data { get; set; }
        public class ListRdUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether the account is delegated to view its own resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DelegatedOrNot")]
            [Validation(Required=false)]
            public bool? DelegatedOrNot { get; set; }

            /// <summary>
            /// <para>Specifies whether the account is managed by the multi-account management feature of Threat Analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The account is managed.</description></item>
            /// <item><description>false: The account is not managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public bool? Joined { get; set; }

            /// <summary>
            /// <para>The time when the account was added to management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2013-10-01 00:00:00</para>
            /// </summary>
            [NameInMap("JoinedTime")]
            [Validation(Required=false)]
            public string JoinedTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that purchased Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID for Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account managed by Threat Analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_account_xxx</para>
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
