// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeBpsDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainRealTimeBpsDataResponseBodyData Data { get; set; }
        public class DescribeDomainRealTimeBpsDataResponseBodyData : TeaModel {
            [NameInMap("BpsModel")]
            [Validation(Required=false)]
            public List<DescribeDomainRealTimeBpsDataResponseBodyDataBpsModel> BpsModel { get; set; }
            public class DescribeDomainRealTimeBpsDataResponseBodyDataBpsModel : TeaModel {
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B49E6DDA-F413-422B-B58E-2FA23F286726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
