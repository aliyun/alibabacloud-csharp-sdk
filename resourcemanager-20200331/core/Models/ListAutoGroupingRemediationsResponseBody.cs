// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAutoGroupingRemediationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Remediations")]
        [Validation(Required=false)]
        public List<ListAutoGroupingRemediationsResponseBodyRemediations> Remediations { get; set; }
        public class ListAutoGroupingRemediationsResponseBodyRemediations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0028d4****cfe94956ef6708a373f396fbc840e306f</para>
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("RemediationTime")]
            [Validation(Required=false)]
            public string RemediationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-uf664f66v1****drkea4</para>
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

            [NameInMap("TargetResourceGroupInfo")]
            [Validation(Required=false)]
            public ListAutoGroupingRemediationsResponseBodyRemediationsTargetResourceGroupInfo TargetResourceGroupInfo { get; set; }
            public class ListAutoGroupingRemediationsResponseBodyRemediationsTargetResourceGroupInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ProjectA</para>
                /// </summary>
                [NameInMap("ResourceGroupDisplayName")]
                [Validation(Required=false)]
                public string ResourceGroupDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-acfmygrk****wfa</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6F959E33-7B6D-5F58-BB0B-ED616DC7C70B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
