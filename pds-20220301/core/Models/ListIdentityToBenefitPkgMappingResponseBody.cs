// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListIdentityToBenefitPkgMappingResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the benefit packages that are associated with an entity.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<IdentityToBenefitPkgMapping> Items { get; set; }

    }

}
