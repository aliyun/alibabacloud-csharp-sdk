// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCenterTransferResponseBody : TeaModel {
        [NameInMap("LiveCenterTransferInfoList")]
        [Validation(Required=false)]
        public DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoList LiveCenterTransferInfoList { get; set; }
        public class DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoList : TeaModel {
            [NameInMap("LiveCenterTransferInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoListLiveCenterTransferInfo> LiveCenterTransferInfo { get; set; }
            public class DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoListLiveCenterTransferInfo : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DstUrl")]
                [Validation(Required=false)]
                public string DstUrl { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TransferArgs")]
                [Validation(Required=false)]
                public string TransferArgs { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4865B85-664B-19D3-BB16-C62FB83C8226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
