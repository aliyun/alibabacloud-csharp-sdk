// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentRequest : TeaModel {
        /// <summary>
        /// <para>Experiment ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public long? ExperimentId { get; set; }

        /// <summary>
        /// <para>Resource Group Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-sdsmfg23</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
