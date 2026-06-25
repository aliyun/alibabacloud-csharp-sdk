// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateSwimmingLaneEnableAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The enabled status of the swimming lane. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled</para>
        /// </description></item>
        /// <item><description><para>false: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The swimming lane group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The swimming lane ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9637</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
