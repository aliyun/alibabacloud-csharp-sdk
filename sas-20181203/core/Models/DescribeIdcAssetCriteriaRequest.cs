// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The status of the IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The IP address is valid.</description></item>
        /// <item><description><b>1</b>: The IP address is ignored.</description></item>
        /// <item><description><em>2</em>: The IP address is invalid.</description></item>
        /// <item><description><em>3</em>: The IP address is expired.</description></item>
        /// <item><description><em>4</em>: The probe that is used to scan the IP address does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The keyword that is used to match assets in fuzzy mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testwww</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
