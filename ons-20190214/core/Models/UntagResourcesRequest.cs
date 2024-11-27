// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags that are attached to the specified resource. This parameter takes effect only if the <b>TagKey</b> parameter is empty. Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>This parameter is required when you detach tags from a topic or a group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BX4jvZZG</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TopicA</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource from which you want to detach tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b></description></item>
        /// <item><description><b>TOPIC</b></description></item>
        /// <item><description><b>GROUP</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TOPIC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CartService</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
