// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnWafGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom WAF rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000135</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
