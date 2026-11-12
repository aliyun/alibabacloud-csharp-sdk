// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictRequest : TeaModel {
        /// <summary>
        /// <para>The region code.</para>
        /// <para>If this parameter is empty, only the edge zones under the specified NetLevelCode are queried.</para>
        /// <para>If this parameter is not empty, only the child edge zones under the specified NetDistrictCode are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100106</para>
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// </summary>
        [NameInMap("NetDistrictCodeNode")]
        [Validation(Required=false)]
        public bool? NetDistrictCodeNode { get; set; }

        /// <summary>
        /// <para>The region level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Big</b>: Area.</description></item>
        /// <item><description><b>Middle</b>: Province.</description></item>
        /// <item><description><b>Small</b>: City.</description></item>
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
