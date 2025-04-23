// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class RefreshAdvisorCostCheckShrinkRequest : TeaModel {
        [NameInMap("AssumeAliyunIdList")]
        [Validation(Required=false)]
        public string AssumeAliyunIdListShrink { get; set; }

        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIdsShrink { get; set; }

        [NameInMap("CheckPlanId")]
        [Validation(Required=false)]
        public long? CheckPlanId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RefreshResource")]
        [Validation(Required=false)]
        public bool? RefreshResource { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

    }

}
