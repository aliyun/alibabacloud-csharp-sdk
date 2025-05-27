// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListRdUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRdUsersResponseBodyData> Data { get; set; }
        public class ListRdUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the account can be used to view the logs and alerts within the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DelegatedOrNot")]
            [Validation(Required=false)]
            public bool? DelegatedOrNot { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is added to the threat analysis feature for centralized management. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public bool? Joined { get; set; }

            /// <summary>
            /// <para>The time when the account was added to the threat analysis feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2013-10-01 00:00:00</para>
            /// </summary>
            [NameInMap("JoinedTime")]
            [Validation(Required=false)]
            public string JoinedTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to perform operations supported by the threat analysis feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// <para>The username of the Alibaba Cloud account that can be used to perform operations supported by the threat analysis feature.</para>
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
