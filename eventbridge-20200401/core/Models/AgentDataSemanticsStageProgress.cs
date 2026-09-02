// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsStageProgress : TeaModel {
        /// <summary>
        /// <para>The stage name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROFILE</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>The stage status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
