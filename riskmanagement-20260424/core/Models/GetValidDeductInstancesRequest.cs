// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetValidDeductInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-fuzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public GetValidDeductInstancesRequestSdkRequest SdkRequest { get; set; }
        public class GetValidDeductInstancesRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sas_cspm_dp_cn-***80001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sas_vul_dp_cn</para>
            /// </summary>
            [NameInMap("Modules")]
            [Validation(Required=false)]
            public string Modules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
