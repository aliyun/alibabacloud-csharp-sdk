// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class CreateManualDagRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-12 00:00:00</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>param_k1=param_v1 param_k2=param_v2</para>
        /// </summary>
        [NameInMap("DagPara")]
        [Validation(Required=false)]
        public string DagPara { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;103180025&quot;: &quot;test=$[yyyy-mm-dd]&quot;}</para>
        /// </summary>
        [NameInMap("NodePara")]
        [Validation(Required=false)]
        public string NodePara { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
