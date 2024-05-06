// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// A list of instance-related specifications.
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestComponents> Components { get; set; }
        public class UpdateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// The specification code, which must be consistent with the values of the corresponding module parameters.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Valid values: UPGRADE and DOWNGRADE. UPGRADE indicates to upgrade the instance specifications. DOWNGRADE indicates to downgrade the instance specifications.
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
