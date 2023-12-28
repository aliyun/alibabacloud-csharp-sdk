// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserListResponseBodyUserList> UserList { get; set; }
        public class DescribeFaultDiagnosisUserListResponseBodyUserList : TeaModel {
            [NameInMap("ChannelCreatedTs")]
            [Validation(Required=false)]
            public long? ChannelCreatedTs { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("FaultList")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserListResponseBodyUserListFaultList> FaultList { get; set; }
            public class DescribeFaultDiagnosisUserListResponseBodyUserListFaultList : TeaModel {
                [NameInMap("FaultType")]
                [Validation(Required=false)]
                public string FaultType { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
