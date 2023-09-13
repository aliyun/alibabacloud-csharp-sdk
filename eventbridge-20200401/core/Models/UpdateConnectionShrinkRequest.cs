// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateConnectionShrinkRequest : TeaModel {
        /// <summary>
        /// The parameters that are configured for authentication.
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public string AuthParametersShrink { get; set; }

        /// <summary>
        /// The name of the connection that you want to update. The name must be 2 to 127 characters in length.
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// The description of the connection. The description can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters that are configured for the network.
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public string NetworkParametersShrink { get; set; }

    }

}
