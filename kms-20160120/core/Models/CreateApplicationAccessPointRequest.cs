// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateApplicationAccessPointRequest : TeaModel {
        /// <summary>
        /// The authentication method. Currently, only ClientKey is supported.
        /// </summary>
        [NameInMap("AuthenticationMethod")]
        [Validation(Required=false)]
        public string AuthenticationMethod { get; set; }

        /// <summary>
        /// The description of the AAP.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the AAP.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The permission policy.
        /// 
        /// > You can bind up to three permission policies to each AAP.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

    }

}
