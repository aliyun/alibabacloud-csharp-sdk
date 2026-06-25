// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Auto-renewal is disabled.</para>
        /// </description></item>
        /// <item><description><para>true: Auto-renewal is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid: subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of new instances to create. The value must be between 1 and 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// <para>The instance type. This corresponds to an ECS instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.s6-c1m2.xlarge</para>
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// <para>The user-defined tags.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The size of the system disk, in GiB. The value must be between 200 and 2,000. If you do not configure this parameter, the default value is 200 GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The custom user data. This parameter is not currently used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x112223333</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        [Obsolete]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The zone where the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
