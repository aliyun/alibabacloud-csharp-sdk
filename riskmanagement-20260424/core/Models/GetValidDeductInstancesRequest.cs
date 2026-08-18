// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetValidDeductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-fuzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request parameters.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public GetValidDeductInstancesRequestSdkRequest SdkRequest { get; set; }
        public class GetValidDeductInstancesRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The resource plan instance ID. You can call QueryResourcePackageInstances to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_cspm_dp_cn-***80001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource plan name code. Valid values:</para>
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
            /// <para>The resource plan status. Default value: valid. This parameter cannot be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
