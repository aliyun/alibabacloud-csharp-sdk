// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictRequest : TeaModel {
        /// <summary>
        /// <para>The code of the region.</para>
        /// <para>If you do not specify this parameter, only nodes in the regions of the level that is specified by the NetLevelCode parameter are queried.</para>
        /// <para>If you specify this parameter, only nodes in the regions of the level that is specified by this parameter are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100106</para>
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// <para>The level of the region.</para>
        /// <list type="bullet">
        /// <item><description><b>Big</b>: area</description></item>
        /// <item><description><b>Middle</b>: province</description></item>
        /// <item><description><b>Small</b>: city</description></item>
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
