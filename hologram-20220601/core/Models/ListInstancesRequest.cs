// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The instance type for Cloud Monitor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>standard</para>
        /// </description></item>
        /// <item><description><para>follower</para>
        /// </description></item>
        /// <item><description><para>mc-acceleration</para>
        /// </description></item>
        /// <item><description><para>warehouse</para>
        /// </description></item>
        /// <item><description><para>high-memory</para>
        /// </description></item>
        /// <item><description><para>serverless</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is for Cloud Monitor.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("cmsInstanceType")]
        [Validation(Required=false)]
        public string CmsInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvscak73zmby</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<ListInstancesRequestTag> Tag { get; set; }
        public class ListInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytag</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
