// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListAICPublicKeyDeliveriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PublicKeyDeliverInfo")]
        [Validation(Required=false)]
        public List<ListAICPublicKeyDeliveriesResponseBodyPublicKeyDeliverInfo> PublicKeyDeliverInfo { get; set; }
        public class ListAICPublicKeyDeliveriesResponseBodyPublicKeyDeliverInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-09T15:13:21+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aic-xxxx-0</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-group</para>
            /// </summary>
            [NameInMap("KeyGroup")]
            [Validation(Required=false)]
            public string KeyGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mykey</para>
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adb</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxsxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
