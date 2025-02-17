// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckCountStatisticRequest : TeaModel {
        /// <summary>
        /// <para>Type of data statistics. Values:  </para>
        /// <list type="bullet">
        /// <item><description><b>user</b>: Top 5 over-authorized users.  </description></item>
        /// <item><description><b>role</b>: Top 5 over-authorized roles.  </description></item>
        /// <item><description><b>instance</b>: Top 5 risky cloud products.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("StatisticType")]
        [Validation(Required=false)]
        public string StatisticType { get; set; }

        /// <summary>
        /// <para>List of cloud vendors.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
