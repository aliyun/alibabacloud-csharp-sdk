// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the invalid custom configuration items of the check item.
        /// </summary>
        [NameInMap("IllegalCustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs> IllegalCustomConfigs { get; set; }
        public class ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs : TeaModel {
            /// <summary>
            /// The name of the custom configuration item, which is unique in a check item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// An array that consists of the invalid parameters required for fixing risk items.
        /// </summary>
        [NameInMap("IllegalRepairConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigResponseBodyIllegalRepairConfigs> IllegalRepairConfigs { get; set; }
        public class ChangeCheckCustomConfigResponseBodyIllegalRepairConfigs : TeaModel {
            /// <summary>
            /// The name of the invalid parameter required for fixing a risk item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
