// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class ImportNumberV2Request : TeaModel {
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<ImportNumberV2RequestCustomers> Customers { get; set; }
        public class ImportNumberV2RequestCustomers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ClientUrl")]
            [Validation(Required=false)]
            public string ClientUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("NumberMD5")]
            [Validation(Required=false)]
            public string NumberMD5 { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailReturn")]
        [Validation(Required=false)]
        public long? FailReturn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
