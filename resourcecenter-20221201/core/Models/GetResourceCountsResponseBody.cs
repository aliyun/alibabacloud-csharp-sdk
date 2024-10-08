// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<GetResourceCountsResponseBodyFilters> Filters { get; set; }
        public class GetResourceCountsResponseBodyFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The dimension by which resources are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D98D9B0-318D-56A4-910C-93B5F945AF2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The numbers of resources.</para>
        /// </summary>
        [NameInMap("ResourceCounts")]
        [Validation(Required=false)]
        public List<GetResourceCountsResponseBodyResourceCounts> ResourceCounts { get; set; }
        public class GetResourceCountsResponseBodyResourceCounts : TeaModel {
            /// <summary>
            /// <para>The number of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::NetworkInterface</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
