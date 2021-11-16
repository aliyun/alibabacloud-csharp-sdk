// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateEdgeMachineRequest : TeaModel {
        /// <summary>
        /// hostname
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// model
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// sn
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
