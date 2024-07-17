// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// The information about the instance specification.
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestComponents> Components { get; set; }
        public class UpdateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// The code of the specification, which must be consistent with the value that you specify on the buy page.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The value of the specification.
            /// </summary>
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
        /// The type of the order. Valid values: UPGRADE and DOWNGRADE. UPGRADE upgrades the instance specifications. DOWNGRADE: downgrades the instance specifications.
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
