// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeKeyPairsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the key pairs.</para>
        /// </summary>
        [NameInMap("KeyPairs")]
        [Validation(Required=false)]
        public DescribeKeyPairsResponseBodyKeyPairs KeyPairs { get; set; }
        public class DescribeKeyPairsResponseBodyKeyPairs : TeaModel {
            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public List<DescribeKeyPairsResponseBodyKeyPairsKeyPair> KeyPair { get; set; }
            public class DescribeKeyPairsResponseBodyKeyPairsKeyPair : TeaModel {
                /// <summary>
                /// <para>The time when the key pair was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-04-26T15:38:27Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The fingerprint of the key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fdaf8ff7a756ef843814fc****</para>
                /// </summary>
                [NameInMap("KeyPairFingerPrint")]
                [Validation(Required=false)]
                public string KeyPairFingerPrint { get; set; }

                /// <summary>
                /// <para>The ID of the key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssh-50cynkq42sgj4ej1tn78t4***</para>
                /// </summary>
                [NameInMap("KeyPairId")]
                [Validation(Required=false)]
                public string KeyPairId { get; set; }

                /// <summary>
                /// <para>The name of the SSH key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKeyPairName</para>
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37B52F33-6879-49D0-A39B-22966B01449E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of key pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
