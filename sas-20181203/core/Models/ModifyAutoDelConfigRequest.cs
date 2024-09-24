// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAutoDelConfigRequest : TeaModel {
        /// <summary>
        /// <para>The number of days after which a detected vulnerability is automatically deleted. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>7</description></item>
        /// <item><description>30</description></item>
        /// <item><description>90</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

    }

}
