// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of records returned by the query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListKmsKeysResponseBodyItems> Items { get; set; }
        public class ListKmsKeysResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The alias of the KMS key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alias/dsc-encryption</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-1234-1234-12345678****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// <para>The request identity, which is active when you invoke the operation to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
