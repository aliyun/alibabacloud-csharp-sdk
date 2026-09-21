// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InvokeContainerRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createSandbox</para>
        /// </summary>
        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
