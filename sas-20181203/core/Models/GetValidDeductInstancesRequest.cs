// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetValidDeductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the resource plan instance. You can call <a href="">QueryResourcePackageInstances</a> to query instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_cspm_dp_cn-***80001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The code of the resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Vulnerability resource plan: <b>sas_vul_dp_cn</b></description></item>
        /// <item><description>CSPM resource plan: <b>sas_cspm_dp_cn</b></description></item>
        /// <item><description>Anti-virus Edition resource plan: <b>sas_viruspackage_dp_cn</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas_vul_dp_cn</para>
        /// </summary>
        [NameInMap("Modules")]
        [Validation(Required=false)]
        public string Modules { get; set; }

        /// <summary>
        /// <para>The status of the resource plan. The default value is valid. This parameter does not support modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
