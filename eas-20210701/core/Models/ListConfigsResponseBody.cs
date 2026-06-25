// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dynamic parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;: &quot;rate_limit&quot;, &quot;Value&quot;: &quot;{\&quot;limit\&quot;: 100}&quot;, &quot;CreatedAt&quot;: &quot;2024-01-15T10:30:00Z&quot;, &quot;UpdatedAt&quot;: &quot;2024-01-15T10:30:00Z&quot;}]</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The time when the dynamic parameter was created, in UTC and ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The name of the dynamic parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rate_limit</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The time when the dynamic parameter was last updated, in UTC and ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The value of the dynamic parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Indicates if more entries are available. <c>true</c> if more entries exist; otherwise, <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-service</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The total number of entries found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The configuration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
