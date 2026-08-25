// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CrawlerType : TeaModel {
        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data Lake Formation</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The list of supported entity types. The entity types have a top-down hierarchical relationship based on their declaration order.</para>
        /// </summary>
        [NameInMap("SupportedEntityTypes")]
        [Validation(Required=false)]
        public List<CrawlerTypeSupportedEntityTypes> SupportedEntityTypes { get; set; }
        public class CrawlerTypeSupportedEntityTypes : TeaModel {
            /// <summary>
            /// <para>Indicates whether the entity type is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For example, for the maxcompute-schema type, whether the schema level is optional (whether the three-layer model is enabled)</para>
            /// </summary>
            [NameInMap("Optional")]
            [Validation(Required=false)]
            public bool? Optional { get; set; }

            /// <summary>
            /// <para>The entity subtype of the parent level. The value is null if no parent level exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("ParentSubType")]
            [Validation(Required=false)]
            public string ParentSubType { get; set; }

            /// <summary>
            /// <para>The entity subtype identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The entity type identifier, which is related to the crawler type. The format is (CrawlerType)-{SubType}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlf-table</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The type identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
