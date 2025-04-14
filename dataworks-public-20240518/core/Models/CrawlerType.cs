// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CrawlerType : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Data Lake Formation</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("SupportedEntityTypes")]
        [Validation(Required=false)]
        public List<CrawlerTypeSupportedEntityTypes> SupportedEntityTypes { get; set; }
        public class CrawlerTypeSupportedEntityTypes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>如对于maxcompute-schema类型，schema层级是否存在可选（是否开启三层模型）</para>
            /// </summary>
            [NameInMap("Optional")]
            [Validation(Required=false)]
            public bool? Optional { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("ParentSubType")]
            [Validation(Required=false)]
            public string ParentSubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dlf-table</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlf</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
