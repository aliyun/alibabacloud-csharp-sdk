// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetEncryptionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The object key.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public GetEncryptionConfigResponseBodyConfig Config { get; set; }
        public class GetEncryptionConfigResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The key alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alias/default</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>561786482014xxxx</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The key ARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:kms:ap-southeast-6:561786482014xxxx:key/5f2fe70a-d110-44cc-990f-706eb20fxxxx</para>
            /// </summary>
            [NameInMap("keyArn")]
            [Validation(Required=false)]
            public string KeyArn { get; set; }

            /// <summary>
            /// <para>The key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5f2fe70a-d110-44cc-990f-706eb20fxxxx</para>
            /// </summary>
            [NameInMap("keyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The key status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// <item><description>PendingDeletion</description></item>
            /// <item><description>PendingImport</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A662F56-CA76-55F6-869D-7F26293B8E67</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
