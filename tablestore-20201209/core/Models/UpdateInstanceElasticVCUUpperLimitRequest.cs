// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class UpdateInstanceElasticVCUUpperLimitRequest : TeaModel {
        /// <summary>
        /// <para>The upper limit for the VCUs of the instance.</para>
        /// <remarks>
        /// <para> Valid values of the upper limit for the VCUs of an instance: <b>Number of reserved VCUs+0.1 to 2000</b>. You can upgrade or downgrade configurations to modify the number of reserved VCUs by increments or decrements of 1. You can dynamically modify the upper limit for the VCUs of an instance by increments or decrements of 0.1</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ElasticVCUUpperLimit")]
        [Validation(Required=false)]
        public float? ElasticVCUUpperLimit { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workshop-bj-ots1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}
