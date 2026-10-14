// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictRequest : TeaModel {
        /// <summary>
        /// <para>The region code.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, only nodes under the area level that is specified by NetLevelCode are queried.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only child nodes in the area that is specified by NetDistrictCode are queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100105</para>
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// <para>The network level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Big</b>: area</para>
        /// </description></item>
        /// <item><description><para><b>Middle</b>: province</para>
        /// </description></item>
        /// <item><description><para><b>Small</b>: city</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Big</para>
        /// </summary>
        [NameInMap("NetLevelCode")]
        [Validation(Required=false)]
        public string NetLevelCode { get; set; }

    }

}
