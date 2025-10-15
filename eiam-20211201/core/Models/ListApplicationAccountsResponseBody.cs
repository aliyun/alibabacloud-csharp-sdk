// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationAccountsResponseBody : TeaModel {
        [NameInMap("ApplicationAccounts")]
        [Validation(Required=false)]
        public List<ListApplicationAccountsResponseBodyApplicationAccounts> ApplicationAccounts { get; set; }
        public class ListApplicationAccountsResponseBodyApplicationAccounts : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 应用账号Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>aac_m66smhbq5krept7nza54hxxxx</para>
            /// </summary>
            [NameInMap("ApplicationAccountId")]
            [Validation(Required=false)]
            public string ApplicationAccountId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_m43o4h5adeo5klvbbxgxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用账号名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApplicationUsername")]
            [Validation(Required=false)]
            public string ApplicationUsername { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737510353000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_eznwtkkaucljizh6qqu7ptxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 用户Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_tkmboufpnvpbitdpzrlngxzxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
