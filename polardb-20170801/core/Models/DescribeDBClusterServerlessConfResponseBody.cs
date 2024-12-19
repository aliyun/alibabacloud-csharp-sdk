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
        /// <para>Whether to enable idle shutdown. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable (default)</para>
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
        /// <para>Serverless cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10gr51qasnl****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E71541A-6007-4DCC-A38A-F872C31FEB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Maximum limit for the number of read-only column storage nodes. Range: 0~7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        /// <summary>
        /// <para>Minimum limit for the number of read-only column storage nodes. Range: 0~7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// <para>Maximum scaling limit for a single node. Range: 1 PCU~32 PCU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>Minimum scaling limit for a single node. Range: 1 PCU~31 PCU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>Maximum scaling limit for the number of read-only nodes. Range: 0~15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// <para>Minimum scaling limit for the number of read-only nodes. Range: 0~15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// <para>Detection duration for idle shutdown. Range: 300~86,400. Unit: seconds. The detection duration must be a multiple of 300 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SecondsUntilAutoPause")]
        [Validation(Required=false)]
        public string SecondsUntilAutoPause { get; set; }

        /// <summary>
        /// <para>CPU upscale threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuEnlargeThreshold { get; set; }

        /// <summary>
        /// <para>CPU downscale threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ServerlessRuleCpuShrinkThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuShrinkThreshold { get; set; }

        /// <summary>
        /// <para>Elasticity sensitivity. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: Standard</para>
        /// </description></item>
        /// <item><description><para>flexible: Sensitive</para>
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
        /// <para>Whether steady state is enabled. Values:</para>
        /// <para>1: Enabled</para>
        /// <para>0: Disabled</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Switchs")]
        [Validation(Required=false)]
        public string Switchs { get; set; }

        [NameInMap("TraditionalScaleMaxThreshold")]
        [Validation(Required=false)]
        public string TraditionalScaleMaxThreshold { get; set; }

    }

}
