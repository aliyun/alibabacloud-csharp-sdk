// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags that are added to the specified SMC resource. This parameter is valid only if you do not set <c>TagKey.N</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: removes all tags that are added to the specified SMC resource. If no tags are added to the specified SMC resource, no operation is performed.</description></item>
        /// <item><description>false: does not remove tags that are added to the specified SMC resource.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of N SMC resources. SMC resources include migration sources and jobs. Valid values of N: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bw526m1vi6x20c6g****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The type of the SMC resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sourceserver: migration source.</description></item>
        /// <item><description>replicationjob: migration job.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sourceserver</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The key of tag N that is added to the SMC resource. Tag keys are case-sensitive. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKey</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
