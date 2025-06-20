// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListResourceRelationshipsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>682A3004-38E3-5122-9A11-CCDFAB9C3C4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource relationships.</para>
        /// </summary>
        [NameInMap("ResourceRelationships")]
        [Validation(Required=false)]
        public List<ListResourceRelationshipsResponseBodyResourceRelationships> ResourceRelationships { get; set; }
        public class ListResourceRelationshipsResponseBodyResourceRelationships : TeaModel {
            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the associated resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6m5okksddm6c9lh7***</para>
            /// </summary>
            [NameInMap("RelatedResourceId")]
            [Validation(Required=false)]
            public string RelatedResourceId { get; set; }

            /// <summary>
            /// <para>The region ID of the associated resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RelatedResourceRegionId")]
            [Validation(Required=false)]
            public string RelatedResourceRegionId { get; set; }

            /// <summary>
            /// <para>The type of the associated resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::VPC::VPC</para>
            /// </summary>
            [NameInMap("RelatedResourceType")]
            [Validation(Required=false)]
            public string RelatedResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-eb3hji****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ACK::Cluster</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
