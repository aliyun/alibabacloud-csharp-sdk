// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaRequest : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// Queries the filter conditions that are used to search for assets in fuzzy match mode.
        /// </summary>
        [NameInMap("SupportAutoTag")]
        [Validation(Required=false)]
        public bool? SupportAutoTag { get; set; }

        /// <summary>
        /// The attribute values of the assets that match the keyword.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
