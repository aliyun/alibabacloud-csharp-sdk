// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListChatConfigurationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;: &quot;status&quot;, &quot;Value&quot;: &quot;inactive&quot;}, {&quot;Name&quot;: &quot;type&quot;, &quot;Value&quot;: &quot;private&quot;}]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListChatConfigurationsRequestFilters> Filters { get; set; }
        public class ListChatConfigurationsRequestFilters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>status</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inactive</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AQEBARoBBgEAAgIBBQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
