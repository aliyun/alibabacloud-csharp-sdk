// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddDeviceBelongIdentifiersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public List<AddDeviceBelongIdentifiersRequestIdentifiers> Identifiers { get; set; }
        public class AddDeviceBelongIdentifiersRequestIdentifiers : TeaModel {
            [NameInMap("IdentifierType")]
            [Validation(Required=false)]
            public string IdentifierType { get; set; }

            [NameInMap("IdentifierValue")]
            [Validation(Required=false)]
            public string IdentifierValue { get; set; }

        }

    }

}
