// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateConsortiumMemberRequest : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateConsortiumMemberRequestOrganization> Organization { get; set; }
        public class CreateConsortiumMemberRequestOrganization : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
