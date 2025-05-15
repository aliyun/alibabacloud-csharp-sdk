// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class UpdateExperimentPlanRequest : TeaModel {
        /// <summary>
        /// <para>Experiment plan ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>189</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        /// <summary>
        /// <para>Experiment plan name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PlanTemplateName")]
        [Validation(Required=false)]
        public string PlanTemplateName { get; set; }

    }

}
