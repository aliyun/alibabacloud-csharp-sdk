// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class LookupResourceGroupEventsResponseBody : TeaModel {
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<LookupResourceGroupEventsResponseBodyEvents> Events { get; set; }
        public class LookupResourceGroupEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Add</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-04T18:35:17Z</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ProjectA</para>
            /// </summary>
            [NameInMap("ResourceGroupDisplayName")]
            [Validation(Required=false)]
            public string ResourceGroupDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfm2sohr74****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-wz9fpfe64****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("SourceResourceGroupInfo")]
            [Validation(Required=false)]
            public LookupResourceGroupEventsResponseBodyEventsSourceResourceGroupInfo SourceResourceGroupInfo { get; set; }
            public class LookupResourceGroupEventsResponseBodyEventsSourceResourceGroupInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestGroupA</para>
                /// </summary>
                [NameInMap("ResourceGroupDisplayName")]
                [Validation(Required=false)]
                public string ResourceGroupDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aekz25pfurj****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            [NameInMap("TargetResourceGroupInfo")]
            [Validation(Required=false)]
            public LookupResourceGroupEventsResponseBodyEventsTargetResourceGroupInfo TargetResourceGroupInfo { get; set; }
            public class LookupResourceGroupEventsResponseBodyEventsTargetResourceGroupInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestGroupB</para>
                /// </summary>
                [NameInMap("ResourceGroupDisplayName")]
                [Validation(Required=false)]
                public string ResourceGroupDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-acfmwfrxcre****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7701451-340B-5CB3-AEA7-7D831F7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
