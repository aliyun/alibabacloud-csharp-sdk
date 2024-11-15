// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99948484</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The name of the Flow that you want to query. If FlowName is left empty, the information about all Flows is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow_001</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The returned pages.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string PageShrink { get; set; }

    }

}
