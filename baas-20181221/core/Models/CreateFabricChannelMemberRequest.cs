// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateFabricChannelMemberRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateFabricChannelMemberRequestOrganization> Organization { get; set; }
        public class CreateFabricChannelMemberRequestOrganization : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
