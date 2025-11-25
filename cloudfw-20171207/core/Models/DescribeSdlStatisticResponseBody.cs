// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>337A4DBA-8A01-5E9C-99CA-84293E13****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdlStatisticResp")]
        [Validation(Required=false)]
        public DescribeSdlStatisticResponseBodySdlStatisticResp SdlStatisticResp { get; set; }
        public class DescribeSdlStatisticResponseBodySdlStatisticResp : TeaModel {
            [NameInMap("SdlAssetTopList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlAssetTopList> SdlAssetTopList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlAssetTopList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>116.62.66.XXX</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TrafficBytes")]
                [Validation(Required=false)]
                public long? TrafficBytes { get; set; }

            }

            [NameInMap("SdlDstTopList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlDstTopList> SdlDstTopList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlDstTopList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>47.101.68.XXX</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TrafficBytes")]
                [Validation(Required=false)]
                public long? TrafficBytes { get; set; }

            }

            [NameInMap("SdlEventTypeCountList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlEventTypeCountList> SdlEventTypeCountList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlEventTypeCountList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

        }

    }

}
