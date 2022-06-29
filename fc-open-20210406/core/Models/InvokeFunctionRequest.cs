// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InvokeFunctionRequest : TeaModel {
        /// <summary>
        /// anything
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public object Body { get; set; }

        /// <summary>
        /// service版本, 可以是versionId或者aliasName
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
