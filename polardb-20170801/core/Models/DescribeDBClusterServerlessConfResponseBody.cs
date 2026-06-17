// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterServerlessConfResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum capacity, in PCUs, for a cluster in agile mode. In agile mode, the cluster consists of only serverless nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("AgileScaleMax")]
        [Validation(Required=false)]
        public string AgileScaleMax { get; set; }

        /// <summary>
        /// <para>Indicates whether the no-activity suspension feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled (Default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowShutDown")]
        [Validation(Required=false)]
        public string AllowShutDown { get; set; }

        /// <summary>
        /// <para>The ID of the serverless cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10gr51qasnl****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E71541A-6007-4DCC-A38A-F872C31FEB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only column store nodes. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only column store nodes. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// <para>The maximum compute capacity of a single node in PCUs. Valid values: 1 to 32.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum compute capacity of a single node in PolarDB Capacity Units (PCUs). Valid values: 1 to 31.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// <para>The detection period for no-activity suspension, in seconds. The value must be an integer from 300 to 86,400 and must be a multiple of 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SecondsUntilAutoPause")]
        [Validation(Required=false)]
        public string SecondsUntilAutoPause { get; set; }

        /// <summary>
        /// <para>The CPU scale-up threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuEnlargeThreshold { get; set; }

        /// <summary>
        /// <para>The CPU scale-down threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuShrinkThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuShrinkThreshold { get; set; }

        /// <summary>
        /// <para>The elasticity sensitivity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: Standard</para>
        /// </description></item>
        /// <item><description><para>flexible: Flexible</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ServerlessRuleMode")]
        [Validation(Required=false)]
        public string ServerlessRuleMode { get; set; }

        /// <summary>
        /// <para>Indicates whether the steady-state mode is enabled. Valid values:</para>
        /// <para>1: Enabled</para>
        /// <para>0: Disabled</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Switchs")]
        [Validation(Required=false)]
        public string Switchs { get; set; }

        /// <summary>
        /// <para>The maximum capacity, in PCUs, for a cluster in steady-state mode. Steady-state mode adds serverless capabilities to nodes that have fixed specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TraditionalScaleMaxThreshold")]
        [Validation(Required=false)]
        public string TraditionalScaleMaxThreshold { get; set; }

    }

}
