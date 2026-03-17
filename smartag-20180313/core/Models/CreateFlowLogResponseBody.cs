// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateFlowLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fl-7a56mar1kfw9vj****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>650CB9E8-20F3-4538-A4FC-1DA1B36E42D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the flow log belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2iu4f****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
