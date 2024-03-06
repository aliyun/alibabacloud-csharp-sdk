// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateApplicationAccessPointRequest : TeaModel {
        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the AAP that you want to update.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The permission policy that you want to update.
        /// > You can associate up to three permission policies with each AAP.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

    }

}
