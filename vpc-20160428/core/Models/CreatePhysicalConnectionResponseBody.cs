// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1ciz7ekd2grn1as****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A6A5EC5-6F6C-4906-9689-56ACE58A13E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
