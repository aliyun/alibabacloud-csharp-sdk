// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMediaPlayDataRequest : TeaModel {
        /// <summary>
        /// <para>The media ID, which is the audio or video ID (VideoId). Specify this parameter filtered query playback data for a specific media file. Only one media ID can be specified. You can obtain the media ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When you upload an audio or video file by calling the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="~~SearchMedia~~">SearchMedia</a> operation filtered query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9ae2af636ca6c10412f44891fc****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The metric name. This parameter is used together with the <c>OrderType</c> parameter. Specify this parameter to sort the returned data in ascending or descending order by a specified metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PlaySuccessVv</b>: total plays.</description></item>
        /// <item><description><b>PlayPerVv</b>: average plays per user.</description></item>
        /// <item><description><b>PlayDuration</b>: total play duration.</description></item>
        /// <item><description><b>PlayDurationPerUv</b>: average play duration per user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlaySuccessVv</para>
        /// </summary>
        [NameInMap("OrderName")]
        [Validation(Required=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para>The sort order. This parameter is used together with the <c>OrderName</c> parameter. Specify this parameter to sort the returned data in ascending or descending order by a specified metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order. The returned data is sorted from smallest to largest.</description></item>
        /// <item><description><b>DESC</b>: descending order. The returned data is sorted from largest to smallest.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The operating system of the playback device. Specify this parameter to perform a filtered query for playback data of all audio and video files by operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Android</b></description></item>
        /// <item><description><b>iOS</b></description></item>
        /// <item><description><b>Windows</b></description></item>
        /// <item><description><b>macOS</b></description></item>
        /// <item><description><b>Linux</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The page number of the data to return. Specify this parameter to set the page from which data starts to be returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Specify this parameter to set the number of entries displayed on each page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The playback date. Unit: day. Format: yyyyMMdd.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only daily queries are supported.</description></item>
        /// <item><description>Only data within the last 30 days can be queried.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20240322</para>
        /// </summary>
        [NameInMap("PlayDate")]
        [Validation(Required=false)]
        public string PlayDate { get; set; }

        /// <summary>
        /// <para>The service region. Specify this parameter to perform a filtered query for playback data of all audio and video files by service region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
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
        /// <para>The terminal type of the Player SDK. Specify this parameter to perform a filtered query for playback data of all audio and video files by terminal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Native</b>: Android Player SDK or iOS Player SDK.</description></item>
        /// <item><description><b>Web</b>: Web Player SDK.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Native</para>
        /// </summary>
        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
