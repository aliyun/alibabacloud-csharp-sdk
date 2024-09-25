// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterServerlessConfResponseBody : TeaModel {
        [NameInMap("AgileScaleMax")]
        [Validation(Required=false)]
        public string AgileScaleMax { get; set; }

        /// <summary>
        /// <para>Indicates whether the no-activity suspension feature is enabled. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E71541A-6007-4DCC-A38A-F872C31FEB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// <para>The maximum number of PCUs per node for scaling. Valid values: 1 PCU to 32 PCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum number of PCUs per node for scaling. Valid values: 1 PCU to 31 PCUs.</para>
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
        /// <para>The detection period for no-activity suspension. Valid values: 300 to 86400. Unit: seconds. The value must be a multiple of 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SecondsUntilAutoPause")]
        [Validation(Required=false)]
        public string SecondsUntilAutoPause { get; set; }

        [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuEnlargeThreshold { get; set; }

        [NameInMap("ServerlessRuleCpuShrinkThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuShrinkThreshold { get; set; }

        [NameInMap("ServerlessRuleMode")]
        [Validation(Required=false)]
        public string ServerlessRuleMode { get; set; }

        [NameInMap("Switchs")]
        [Validation(Required=false)]
        public string Switchs { get; set; }

        [NameInMap("TraditionalScaleMaxThreshold")]
        [Validation(Required=false)]
        public string TraditionalScaleMaxThreshold { get; set; }

    }

}
