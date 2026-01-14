// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AttachDdosToAcceleratorResponseBody : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro/Premium instance that is associated with the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-zz11vq7j****</para>
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosId { get; set; }

        /// <summary>
        /// <para>The ID of the GA instance that is associated with the Anti-DDoS Pro/Premium instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("GaId")]
        [Validation(Required=false)]
        public string GaId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
