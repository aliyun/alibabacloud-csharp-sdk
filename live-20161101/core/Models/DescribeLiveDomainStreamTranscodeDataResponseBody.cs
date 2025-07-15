// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStreamTranscodeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding usage data returned at each interval.</para>
        /// </summary>
        [NameInMap("TranscodeDataList")]
        [Validation(Required=false)]
        public DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList TranscodeDataList { get; set; }
        public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList : TeaModel {
            [NameInMap("TranscodeData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData> TranscodeData { get; set; }
            public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData : TeaModel {
                /// <summary>
                /// <para>The main streaming domain. This parameter is returned only when you add the domain key to the value of the Split parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The transcoding length. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The frame rate of the transcoded stream. This parameter is returned only when you add the fps key to the value of the Split parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The region in which the domain name resides. Valid values:</para>
                /// <remarks>
                /// <para> This parameter takes effect only when you set Split to region.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
                /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
                /// <item><description><b>cn-qingdao</b>: China (Qingdao)</description></item>
                /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
                /// <item><description><b>ap-northeast-1</b>: Japan (Tokyo)</description></item>
                /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
                /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta)</description></item>
                /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The resolution of the transcoded stream. This parameter is returned only when you add the resolution key to the value of the Split parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2K</b></description></item>
                /// <item><description><b>4K</b></description></item>
                /// <item><description><b>LD</b>: low definition</description></item>
                /// <item><description><b>SD</b>: standard definition</description></item>
                /// <item><description><b>HD</b>: high definition</description></item>
                /// <item><description><b>def</b>: audio</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HD</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// <para>The transcoding type. Valid values:</para>
                /// <remarks>
                /// <para> This parameter takes effect only if the request parameter Split is set to transcode_type.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>H264NBHD</b>: Narrowband HD™ transcoding based on H.264</description></item>
                /// <item><description><b>H265NBHD</b>: Narrowband HD™ transcoding based on H.265</description></item>
                /// <item><description><b>AUDIO</b>: audio transcoding</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H264STD</para>
                /// </summary>
                [NameInMap("TanscodeType")]
                [Validation(Required=false)]
                public string TanscodeType { get; set; }

                /// <summary>
                /// <para>The timestamp of the data entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
