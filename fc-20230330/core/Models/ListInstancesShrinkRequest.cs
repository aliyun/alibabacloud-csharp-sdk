// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        [NameInMap("endTimeMs")]
        [Validation(Required=false)]
        public long? EndTimeMs { get; set; }

        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatusShrink { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The function version or alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("startKey")]
        [Validation(Required=false)]
        public string StartKey { get; set; }

        [NameInMap("startTimeMs")]
        [Validation(Required=false)]
        public long? StartTimeMs { get; set; }

        /// <summary>
        /// <para>Specifies whether to list all instances. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAllActive")]
        [Validation(Required=false)]
        public bool? WithAllActive { get; set; }

    }

}
