// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateConsortiumRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelPolicy")]
        [Validation(Required=false)]
        public string ChannelPolicy { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrdererType")]
        [Validation(Required=false)]
        public string OrdererType { get; set; }

        [NameInMap("OrderersCount")]
        [Validation(Required=false)]
        public int? OrderersCount { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateConsortiumRequestOrganization> Organization { get; set; }
        public class CreateConsortiumRequestOrganization : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("PeersCount")]
        [Validation(Required=false)]
        public int? PeersCount { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
