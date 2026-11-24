// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags from the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Unbinds all tags from the resource.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not unbind all tags.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set both <b>TagKey.n</b> and this parameter, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

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
        /// <para>The resource ID. You can specify up to 20 resources.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Currently, Instance resources are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key. Valid values of N: 1 to 20.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
