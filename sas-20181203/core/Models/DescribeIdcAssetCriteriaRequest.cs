// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the corresponding IP address is valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: valid</description></item>
        /// <item><description><b>1</b>: ignored</description></item>
        /// <item><description><b>2</b>: invalid</description></item>
        /// <item><description><b>3</b>: expired</description></item>
        /// <item><description><b>4</b>: probe does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The fuzzy match value entered when querying assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testwww</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
