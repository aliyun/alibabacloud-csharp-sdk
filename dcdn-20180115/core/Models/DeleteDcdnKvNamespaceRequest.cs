// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnKvNamespaceRequest : TeaModel {
        /// <summary>
        /// The name of the namespace. You can call the [PutDcdnKvNamespace](~~PutDcdnKvNamespace~~) operation to query the name of a namespace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
