// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunNodeOperationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the O&amp;M action to execute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>restart.kubelet</para>
        /// </summary>
        [NameInMap("operationAction")]
        [Validation(Required=false)]
        public string OperationAction { get; set; }

        /// <summary>
        /// <para>The list of parameters for the O&amp;M action.</para>
        /// </summary>
        [NameInMap("operationArgs")]
        [Validation(Required=false)]
        public List<string> OperationArgs { get; set; }

    }

}
