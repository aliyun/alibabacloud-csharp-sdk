// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchAddressGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The location-based groups.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<AddressGroup> Items { get; set; }

    }

}
