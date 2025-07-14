// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetGovernanceItemReportRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SSOLoginEnabled</para>
        /// </summary>
        [NameInMap("GovernanceItemType")]
        [Validation(Required=false)]
        public string GovernanceItemType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public string MaxItems { get; set; }

    }

}
