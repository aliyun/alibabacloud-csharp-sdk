// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeSpotDiscountHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The type of the Elastic Algorithm Service (EAS) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.4xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the preemptible instance has a protection period. During the 1-hour protection period of the preemptible instance, the preemptible instance will not be released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsProtect")]
        [Validation(Required=false)]
        public bool? IsProtect { get; set; }

    }

}
