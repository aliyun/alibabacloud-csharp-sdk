// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableZoneRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>multiple</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.2.4.4</para>
        /// </summary>
        [NameInMap("ObVersion")]
        [Validation(Required=false)]
        public string ObVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oceanbase.cluster.cd8.xlarge</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
