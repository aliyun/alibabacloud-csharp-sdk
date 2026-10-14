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
        /// <para>Region code</para>
        /// </summary>
        [NameInMap("NetDistrictCodeNode")]
        [Validation(Required=false)]
        public bool? NetDistrictCodeNode { get; set; }

        /// <summary>
        /// <para>The level of the region.</para>
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
