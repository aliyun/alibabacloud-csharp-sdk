// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a service-linked role exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? HasServiceLinkedRole { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66428721-xxxx-xxxx-xxxx-3BD1B67837E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
