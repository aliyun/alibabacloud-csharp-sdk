// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeResourceConstraintsRequest : TeaModel {
        /// <summary>
        /// <para>The instance architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>onEci: Deployed on ECI.</description></item>
        /// <item><description>onEcs: Deployed on ECS.</description></item>
        /// <item><description>onBareMetal: Deployed on a bare metal resource pool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onEcs</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>trial: Trial edition.</description></item>
        /// <item><description>official: Standard edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>trial</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The running mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shared_nothing: Integrated storage and compute.</description></item>
        /// <item><description>shared_data: Separated storage and compute.</description></item>
        /// <item><description>lakehouse: Data lakehouse analysis.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shared_data</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

    }

}
