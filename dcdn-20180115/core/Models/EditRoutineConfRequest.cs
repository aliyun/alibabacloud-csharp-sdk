// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class EditRoutineConfRequest : TeaModel {
        /// <summary>
        /// The description of the routine.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The configurations of the specified environment.
        /// </summary>
        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> EnvConf { get; set; }

        /// <summary>
        /// The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
