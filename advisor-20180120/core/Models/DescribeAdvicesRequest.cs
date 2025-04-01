// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvicesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("AdviceId")]
        [Validation(Required=false)]
        public long? AdviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EcsHighCpuUtilization</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        [NameInMap("CheckPlanId")]
        [Validation(Required=false)]
        public long? CheckPlanId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("ExcludeAdviceId")]
        [Validation(Required=false)]
        public long? ExcludeAdviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
