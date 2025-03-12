// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeZones</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The deployment mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

    }

}
