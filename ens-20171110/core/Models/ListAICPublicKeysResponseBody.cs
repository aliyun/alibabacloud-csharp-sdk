// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListAICPublicKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number when paging</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Public key list</para>
        /// </summary>
        [NameInMap("PublicKeys")]
        [Validation(Required=false)]
        public List<ListAICPublicKeysResponseBodyPublicKeys> PublicKeys { get; set; }
        public class ListAICPublicKeysResponseBodyPublicKeys : TeaModel {
            /// <summary>
            /// <para>Public key content</para>
            /// 
            /// <b>Example:</b>
            /// <para>fvsvshbvjfksvj</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time of the voiceprint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-09T15:13:21+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Public key description</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Public key grouping</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-group</para>
            /// </summary>
            [NameInMap("KeyGroup")]
            [Validation(Required=false)]
            public string KeyGroup { get; set; }

            /// <summary>
            /// <para>Public key name</para>
            /// 
            /// <b>Example:</b>
            /// <para>mykey</para>
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// <para>Public key type</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxsxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
