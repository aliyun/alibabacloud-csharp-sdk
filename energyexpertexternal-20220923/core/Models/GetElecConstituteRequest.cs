// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecConstituteRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Year.
        /// </summary>
        [NameInMap("year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
