// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetIfEcsTypeSupportHtConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether Hyper-Threading is enabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Hyper-Threading is enabled by default.</description></item>
        /// <item><description>false: Hyper-Threading is disabled by default.</description></item>
        /// </list>
        /// <remarks>
        /// <para> By default, Hyper-Threading is not enabled for Super Computing Cluster (SCC) instance families but is enabled for other instance families.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DefaultHtEnabled")]
        [Validation(Required=false)]
        public bool? DefaultHtEnabled { get; set; }

        /// <summary>
        /// <para>The ECS instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80CA7A93-7291-4402-B63D-86DF334E0A1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether hyper-threading is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Hyper-threading is supported.</description></item>
        /// <item><description>false: Hyper-threading is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportHtConfig")]
        [Validation(Required=false)]
        public bool? SupportHtConfig { get; set; }

    }

}
