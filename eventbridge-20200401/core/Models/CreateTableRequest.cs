// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateTableRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e9b8f60-3a2c-4d7e-9f1b-8c3d5e7a2b4f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The column definitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;,&quot;Comment&quot;:&quot;Primary key&quot;}]</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateTableRequestColumns> Columns { get; set; }
        public class CreateTableRequestColumns : TeaModel {
            /// <summary>
            /// <para>The comment of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Isp</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The connector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpc_cluster</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test event table</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The data retention policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HotTTL&quot;:7,&quot;ColdTTL&quot;:30}</para>
        /// </summary>
        [NameInMap("RetentionPolicy")]
        [Validation(Required=false)]
        public CreateTableRequestRetentionPolicy RetentionPolicy { get; set; }
        public class CreateTableRequestRetentionPolicy : TeaModel {
            /// <summary>
            /// <para>The cold storage duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ColdTTL")]
            [Validation(Required=false)]
            public int? ColdTTL { get; set; }

            /// <summary>
            /// <para>The hot storage duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("HotTTL")]
            [Validation(Required=false)]
            public int? HotTTL { get; set; }

        }

    }

}
