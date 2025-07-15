// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth data returned at each interval.</para>
        /// </summary>
        [NameInMap("DetectPornData")]
        [Validation(Required=false)]
        public DescribeLiveDetectPornDataResponseBodyDetectPornData DetectPornData { get; set; }
        public class DescribeLiveDetectPornDataResponseBodyDetectPornData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule> DataModule { get; set; }
            public class DescribeLiveDetectPornDataResponseBodyDetectPornDataDataModule : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                /// <summary>
                /// <para>The number of reviewed images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>Indicates whether a quota of free image scanning is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>free</b></description></item>
                /// <item><description><b>charge</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>free</para>
                /// </summary>
                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                /// <summary>
                /// <para>The region in which the domain name resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The moderation scenario. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b> (default): pornography</description></item>
                /// <item><description><b>terrorism</b>: terrorism or politically sensitive content</description></item>
                /// <item><description><b>ad</b>: ad violation</description></item>
                /// <item><description><b>live</b>: undesirable scene</description></item>
                /// <item><description><b>logo</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T15:00:05Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
