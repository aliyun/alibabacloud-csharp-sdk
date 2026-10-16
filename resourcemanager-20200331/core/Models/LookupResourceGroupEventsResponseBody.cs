// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class LookupResourceGroupEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<LookupResourceGroupEventsResponseBodyEvents> Events { get; set; }
        public class LookupResourceGroupEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The change type of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Add</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <para>The event time in RFC 3339 UTC format, indicated by Z for UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-04T18:35:17Z</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ProjectA</para>
            /// </summary>
            [NameInMap("ResourceGroupDisplayName")]
            [Validation(Required=false)]
            public string ResourceGroupDisplayName { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm2sohr74****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fpfe64****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>You can obtain the value from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The cloud service code.</para>
            /// <para>You can obtain the value from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The source resource group.</para>
            /// </summary>
            [NameInMap("SourceResourceGroupInfo")]
            [Validation(Required=false)]
            public LookupResourceGroupEventsResponseBodyEventsSourceResourceGroupInfo SourceResourceGroupInfo { get; set; }
            public class LookupResourceGroupEventsResponseBodyEventsSourceResourceGroupInfo : TeaModel {
                /// <summary>
                /// <para>The resource group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroupA</para>
                /// </summary>
                [NameInMap("ResourceGroupDisplayName")]
                [Validation(Required=false)]
                public string ResourceGroupDisplayName { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekz25pfurj****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The target resource group.</para>
            /// </summary>
            [NameInMap("TargetResourceGroupInfo")]
            [Validation(Required=false)]
            public LookupResourceGroupEventsResponseBodyEventsTargetResourceGroupInfo TargetResourceGroupInfo { get; set; }
            public class LookupResourceGroupEventsResponseBodyEventsTargetResourceGroupInfo : TeaModel {
                /// <summary>
                /// <para>The resource group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroupB</para>
                /// </summary>
                [NameInMap("ResourceGroupDisplayName")]
                [Validation(Required=false)]
                public string ResourceGroupDisplayName { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmwfrxcre****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7701451-340B-5CB3-AEA7-7D831F7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
