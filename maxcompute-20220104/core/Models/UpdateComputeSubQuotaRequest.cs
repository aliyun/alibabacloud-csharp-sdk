// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeSubQuotaRequest : TeaModel {
        [NameInMap("subQuotaInfoList")]
        [Validation(Required=false)]
        public List<UpdateComputeSubQuotaRequestSubQuotaInfoList> SubQuotaInfoList { get; set; }
        public class UpdateComputeSubQuotaRequestSubQuotaInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("parameter")]
            [Validation(Required=false)]
            public UpdateComputeSubQuotaRequestSubQuotaInfoListParameter Parameter { get; set; }
            public class UpdateComputeSubQuotaRequestSubQuotaInfoListParameter : TeaModel {
                [NameInMap("enablePriority")]
                [Validation(Required=false)]
                public bool? EnablePriority { get; set; }

                [NameInMap("forceReservedMin")]
                [Validation(Required=false)]
                public bool? ForceReservedMin { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("maxCU")]
                [Validation(Required=false)]
                public long? MaxCU { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("minCU")]
                [Validation(Required=false)]
                public long? MinCU { get; set; }

                [NameInMap("schedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("singleJobCULimit")]
                [Validation(Required=false)]
                public long? SingleJobCULimit { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
