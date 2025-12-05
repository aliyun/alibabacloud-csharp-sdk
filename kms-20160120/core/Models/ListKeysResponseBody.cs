// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the CMKs of the current Alibaba Cloud account in the current region.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListKeysResponseBodyKeys Keys { get; set; }
        public class ListKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<ListKeysResponseBodyKeysKey> Key { get; set; }
            public class ListKeysResponseBodyKeysKey : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the CMK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:kms:cn-hangzhou:123456:key/80e9409f-78fa-42ab-84bd-83f40c81****</para>
                /// </summary>
                [NameInMap("KeyArn")]
                [Validation(Required=false)]
                public string KeyArn { get; set; }

                /// <summary>
                /// <para>The ID of the CMK. The ID must be globally unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8252db58-2036-408c-a3d5-56e656dc2551</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of CMKs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
