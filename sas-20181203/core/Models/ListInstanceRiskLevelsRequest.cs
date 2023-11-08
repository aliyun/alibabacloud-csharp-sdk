// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskLevelsRequest : TeaModel {
        /// <summary>
        /// The instances.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstanceRiskLevelsRequestInstanceList> InstanceList { get; set; }
        public class ListInstanceRiskLevelsRequestInstanceList : TeaModel {
            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The serial number of the instance.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
