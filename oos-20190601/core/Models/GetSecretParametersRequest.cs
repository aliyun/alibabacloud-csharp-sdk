// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParametersRequest : TeaModel {
        /// <summary>
        /// The name of the encryption parameter. Multiple encryption parameters can form a JSON array in the format of ["xxxxxxxxx", "yyyyyyyyy", … "zzzzzzzzz"]. Each JSON array can contain a maximum of 10 encryption parameters. Multiple encryption parameters in the array are separated by commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to decrypt the parameter value. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("WithDecryption")]
        [Validation(Required=false)]
        public bool? WithDecryption { get; set; }

    }

}
