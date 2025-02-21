// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExecStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeStrategy~~">DescribeStrategy</a> operation to query the IDs of baseline check policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>215421</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public int? StrategyId { get; set; }

    }

}
