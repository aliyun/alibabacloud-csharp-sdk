// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampResponseBody : TeaModel {
        [NameInMap("BpsDataList")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList BpsDataList { get; set; }
        public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList : TeaModel {
            [NameInMap("BpsDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel> BpsDataModel { get; set; }
            public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel : TeaModel {
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public long? Bps { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
