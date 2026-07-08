// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListPublicKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>A list of public keys.</para>
        /// </summary>
        [NameInMap("PublicKeys")]
        [Validation(Required=false)]
        public List<ListPublicKeysResponseBodyPublicKeys> PublicKeys { get; set; }
        public class ListPublicKeysResponseBodyPublicKeys : TeaModel {
            /// <summary>
            /// <para>The content of the public key. The content is encoded in Base64 format by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_30d89ccb0905c8c7882c1d14a991954b</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The description of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试使用</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The public key group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mygroup</para>
            /// </summary>
            [NameInMap("KeyGroup")]
            [Validation(Required=false)]
            public string KeyGroup { get; set; }

            /// <summary>
            /// <para>The name of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mykey</para>
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// <para>The type of the public key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>adb</b>: ADB key</para>
            /// </description></item>
            /// <item><description><para><b>ssh</b>: SSH key</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ssh</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            /// <summary>
            /// <para>The time when the public key was uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-11T14:26:48+08:00</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
