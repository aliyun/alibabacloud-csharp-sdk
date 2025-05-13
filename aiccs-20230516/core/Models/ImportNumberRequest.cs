// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class ImportNumberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<ImportNumberRequestCustomers> Customers { get; set; }
        public class ImportNumberRequestCustomers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://test.com">http://test.com</a></para>
            /// </summary>
            [NameInMap("ClientUrl")]
            [Validation(Required=false)]
            public string ClientUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13541251222,18665214444</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("NumberMD5")]
            [Validation(Required=false)]
            public string NumberMD5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;testt&quot;:&quot;123&quot;}</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailReturn")]
        [Validation(Required=false)]
        public long? FailReturn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
