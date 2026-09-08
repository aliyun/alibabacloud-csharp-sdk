// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class CreateDataMaskingRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AES_256_GCM</para>
        /// </summary>
        [NameInMap("EncAlgorithm")]
        [Validation(Required=false)]
        public string EncAlgorithm { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>client_key</para>
        /// </summary>
        [NameInMap("EncryptionKeyMode")]
        [Validation(Required=false)]
        public string EncryptionKeyMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2145953410000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRESERVE</para>
        /// </summary>
        [NameInMap("ExpireTimeOperation")]
        [Validation(Required=false)]
        public string ExpireTimeOperation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("RiskHandleId")]
        [Validation(Required=false)]
        public long? RiskHandleId { get; set; }

        [NameInMap("SubRuleList")]
        [Validation(Required=false)]
        public List<CreateDataMaskingRuleRequestSubRuleList> SubRuleList { get; set; }
        public class CreateDataMaskingRuleRequestSubRuleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>phone,email</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public string Columns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>business_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<CreateDataMaskingRuleRequestUserList> UserList { get; set; }
        public class CreateDataMaskingRuleRequestUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

        }

    }

}
