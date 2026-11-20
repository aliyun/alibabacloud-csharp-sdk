// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether cascade delete is enabled. If enabled, deleting the service group automatically deletes all services in the service group. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CascadeDelete")]
        [Validation(Required=false)]
        public string CascadeDelete { get; set; }

    }

}
