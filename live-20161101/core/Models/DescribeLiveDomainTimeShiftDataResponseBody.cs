// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTimeShiftDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AE1CB3A-6510-442E-A6B9-EF03D05B3E09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeShiftData")]
        [Validation(Required=false)]
        public DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData TimeShiftData { get; set; }
        public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule : TeaModel {
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
