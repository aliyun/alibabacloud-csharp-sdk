// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class BatchSaveInstructionStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ib</para>
        /// </summary>
        [NameInMap("pKey")]
        [Validation(Required=false)]
        public string PKey { get; set; }

        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

    }

}
