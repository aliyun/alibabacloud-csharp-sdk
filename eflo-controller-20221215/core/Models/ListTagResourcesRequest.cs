// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token that determines the start position of the query. Set this parameter to the value of the NextToken parameter that is returned from the last call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdQ3Z+oPlg49gsr2y8jb6wY=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the resources.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Node</description></item>
        /// <item><description>Vcc</description></item>
        /// <item><description>Cluster</description></item>
        /// <item><description>Subnet</description></item>
        /// <item><description>Vpd</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PodName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WFT-OTC</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
