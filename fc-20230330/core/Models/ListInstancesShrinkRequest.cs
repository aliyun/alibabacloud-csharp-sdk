// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time (UNIX timestamp in milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790899200000</para>
        /// </summary>
        [NameInMap("endTimeMs")]
        [Validation(Required=false)]
        public long? EndTimeMs { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of instance statuses.</para>
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatusShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of instances to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The version or alias of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The start marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-01234567-89abcdef-0123456789ab～</para>
        /// </summary>
        [NameInMap("startKey")]
        [Validation(Required=false)]
        public string StartKey { get; set; }

        /// <summary>
        /// <para>The start time (UNIX timestamp in milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790812800000</para>
        /// </summary>
        [NameInMap("startTimeMs")]
        [Validation(Required=false)]
        public long? StartTimeMs { get; set; }

        /// <summary>
        /// <para>Specifies whether to list all instances. Valid values: true, false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAllActive")]
        [Validation(Required=false)]
        public bool? WithAllActive { get; set; }

    }

}
