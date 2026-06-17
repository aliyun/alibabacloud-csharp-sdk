// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CheckPolarFsQuotaConsistencyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to repair an inconsistent quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false</para>
        /// </description></item>
        /// <item><description><para>true</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRepair")]
        [Validation(Required=false)]
        public bool? EnableRepair { get; set; }

        /// <summary>
        /// <para>Specifies whether to calculate the total usage of the directory in strict mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false</para>
        /// </description></item>
        /// <item><description><para>true</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableStrictCalculate")]
        [Validation(Required=false)]
        public bool? EnableStrictCalculate { get; set; }

        /// <summary>
        /// <para>The directory path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The ID of the PolarFS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-test****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
