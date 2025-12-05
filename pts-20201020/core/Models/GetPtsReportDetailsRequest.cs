// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsReportDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the performance testing task. A task ID is generated each time a PTS scenario is started.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OH5HA3VB</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The ID of the scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>G5HCVS</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
