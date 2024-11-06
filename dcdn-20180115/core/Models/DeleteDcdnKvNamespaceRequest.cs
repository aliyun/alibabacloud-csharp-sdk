// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnKvNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the namespace. You can call the <a href="~~PutDcdnKvNamespace~~">PutDcdnKvNamespace</a> operation to query the name of a namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
