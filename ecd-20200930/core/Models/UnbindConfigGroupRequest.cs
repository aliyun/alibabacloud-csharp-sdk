// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UnbindConfigGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region. Set the value to <c>cn-shanghai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resources from which you want to unbind the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInfos")]
        [Validation(Required=false)]
        public List<UnbindConfigGroupRequestResourceInfos> ResourceInfos { get; set; }
        public class UnbindConfigGroupRequestResourceInfos : TeaModel {
            /// <summary>
            /// <para>The service type of the resource.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>CLOUD_DESKTOP: the cloud computer service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-ctwj0bk3l5nz****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RESOURCE_GROUP: the resource group.</description></item>
            /// <item><description>CLOUD_DESKTOP: the cloud computer service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The type of the configuration group.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Timer: the scheduled task type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Timer</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
