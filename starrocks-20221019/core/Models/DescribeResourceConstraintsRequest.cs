// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeResourceConstraintsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the instance architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>onEci: The instance is deployed on ECI.</para>
        /// </description></item>
        /// <item><description><para>onEcs: The instance is deployed on ECS.</para>
        /// </description></item>
        /// <item><description><para>onBareMetal: The instance is deployed on a bare metal resource pool.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onEcs</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Specifies the instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>trial: The entry-level edition.</para>
        /// </description></item>
        /// <item><description><para>official: The Standard Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>trial</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>Specifies the run mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>shared_nothing: The shared-nothing mode.</para>
        /// </description></item>
        /// <item><description><para>shared_data: The shared-data mode.</para>
        /// </description></item>
        /// <item><description><para>lakehouse: The data lake analytics mode.</para>
        /// </description></item>
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
