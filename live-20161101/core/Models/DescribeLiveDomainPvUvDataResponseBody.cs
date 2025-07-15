// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPvUvDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the entries returned. Unit: seconds. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data of PVs and UVs.</para>
        /// </summary>
        [NameInMap("PvUvDataInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfos PvUvDataInfos { get; set; }
        public class DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfos : TeaModel {
            [NameInMap("PvUvDataInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo> PvUvDataInfo { get; set; }
            public class DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo : TeaModel {
                /// <summary>
                /// <para>The number of PVs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3036</para>
                /// </summary>
                [NameInMap("PV")]
                [Validation(Required=false)]
                public string PV { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ssZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-03-19T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The number of UVs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UV")]
                [Validation(Required=false)]
                public string UV { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9D3257A-1B7C-414C-90C1-8D07AC47BCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-17T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
