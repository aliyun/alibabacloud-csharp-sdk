// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGasConstituteRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Module code.
        /// </summary>
        [NameInMap("moduleCode")]
        [Validation(Required=false)]
        public string ModuleCode { get; set; }

        /// <summary>
        /// Module type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("moduleType")]
        [Validation(Required=false)]
        public int? ModuleType { get; set; }

        /// <summary>
        /// Year
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
