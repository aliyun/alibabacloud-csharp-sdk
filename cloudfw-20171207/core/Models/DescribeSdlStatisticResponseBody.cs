// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337A4DBA-8A01-5E9C-99CA-84293E13****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the sensitive data.</para>
        /// </summary>
        [NameInMap("SdlStatisticResp")]
        [Validation(Required=false)]
        public DescribeSdlStatisticResponseBodySdlStatisticResp SdlStatisticResp { get; set; }
        public class DescribeSdlStatisticResponseBodySdlStatisticResp : TeaModel {
            /// <summary>
            /// <para>A ranked list of sensitive data assets.</para>
            /// </summary>
            [NameInMap("SdlAssetTopList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlAssetTopList> SdlAssetTopList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlAssetTopList : TeaModel {
                /// <summary>
                /// <para>The asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.62.66.XXX</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// <para>The amount of traffic in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TrafficBytes")]
                [Validation(Required=false)]
                public long? TrafficBytes { get; set; }

            }

            /// <summary>
            /// <para>A ranked list of sensitive data destinations.</para>
            /// </summary>
            [NameInMap("SdlDstTopList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlDstTopList> SdlDstTopList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlDstTopList : TeaModel {
                /// <summary>
                /// <para>The public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.101.68.XXX</para>
                /// </summary>
                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                /// <summary>
                /// <para>The amount of traffic in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TrafficBytes")]
                [Validation(Required=false)]
                public long? TrafficBytes { get; set; }

            }

            /// <summary>
            /// <para>A list of counts for each sensitive data event type.</para>
            /// </summary>
            [NameInMap("SdlEventTypeCountList")]
            [Validation(Required=false)]
            public List<DescribeSdlStatisticResponseBodySdlStatisticRespSdlEventTypeCountList> SdlEventTypeCountList { get; set; }
            public class DescribeSdlStatisticResponseBodySdlStatisticRespSdlEventTypeCountList : TeaModel {
                /// <summary>
                /// <para>The total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id_card</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

        }

    }

}
