// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVbrHaResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the VBR failover group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbrha-sa1sxheuxtd98****</para>
        /// </summary>
        [NameInMap("VbrHaId")]
        [Validation(Required=false)]
        public string VbrHaId { get; set; }

    }

}
