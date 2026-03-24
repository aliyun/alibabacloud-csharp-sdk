// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetValidDeductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Resource package instance ID, can be queried through <a href="">QueryResourcePackageInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_cspm_dp_cn-***80001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Resource package name code, values:</para>
        /// <list type="bullet">
        /// <item><description>Vulnerability resource package: <b>sas_vul_dp_cn</b></description></item>
        /// <item><description>CSPM resource package: <b>sas_cspm_dp_cn</b></description></item>
        /// <item><description>Anti-virus resource package: <b>sas_viruspackage_dp_cn</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas_vul_dp_cn</para>
        /// </summary>
        [NameInMap("Modules")]
        [Validation(Required=false)]
        public string Modules { get; set; }

        /// <summary>
        /// <para>Resource package status, default is valid (valid), not modifiable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
