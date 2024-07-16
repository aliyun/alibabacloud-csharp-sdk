// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class CreateWirelessCloudConnectorRequest : TeaModel {
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetLinks")]
        [Validation(Required=false)]
        public List<CreateWirelessCloudConnectorRequestNetLinks> NetLinks { get; set; }
        public class CreateWirelessCloudConnectorRequestNetLinks : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("APN")]
            [Validation(Required=false)]
            public string APN { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VSwitchs")]
            [Validation(Required=false)]
            public List<string> VSwitchs { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UseCase")]
        [Validation(Required=false)]
        public string UseCase { get; set; }

    }

}
