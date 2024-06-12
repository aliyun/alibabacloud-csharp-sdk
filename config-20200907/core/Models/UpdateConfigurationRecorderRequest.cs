// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigurationRecorderRequest : TeaModel {
        /// <summary>
        /// The resource types. Separate multiple resource types with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
