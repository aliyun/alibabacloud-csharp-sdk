// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the resources. This parameter takes effect only when TagKey.N is not specified. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The list of resource IDs, which are cloud phone IDs. You can specify 1 to 50 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALIYUN::ACP::INSTANCE: Cloud phone.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ACP::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys. You can specify 1 to 20 tag keys.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
