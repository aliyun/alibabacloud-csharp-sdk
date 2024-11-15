// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyFlowRequest : TeaModel {
        /// <summary>
        /// <para>The information about the categories of the Flow.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9493884</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The Flow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2938838</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The name of the Flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow_001</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
