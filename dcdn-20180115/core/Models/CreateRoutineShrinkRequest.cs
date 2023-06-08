// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateRoutineShrinkRequest : TeaModel {
        /// <summary>
        /// The configurations of the specified environment.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.
        /// </summary>
        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConfShrink { get; set; }

        /// <summary>
        /// > 
        /// *   The parameters must comply with the rules of EnvConf. The description of a routine cannot exceed 50 characters in length.
        /// *   This operation creates a routine that contains only production and staging environments.
        /// *   You can call this operation up to 100 times per second.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
