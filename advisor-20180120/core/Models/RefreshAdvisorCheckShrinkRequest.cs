// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class RefreshAdvisorCheckShrinkRequest : TeaModel {
        [NameInMap("AssumeAliyunId")]
        [Validation(Required=false)]
        public long? AssumeAliyunId { get; set; }

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

        [NameInMap("ResourceDimensionList")]
        [Validation(Required=false)]
        public string ResourceDimensionListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
