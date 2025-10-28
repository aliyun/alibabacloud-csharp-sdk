// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteEcuRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the ECU to be deleted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0b8c82-4ba9-<b><b>-</b></b>-130a34ffa534</para>
        /// </summary>
        [NameInMap("EcuId")]
        [Validation(Required=false)]
        public string EcuId { get; set; }

    }

}
