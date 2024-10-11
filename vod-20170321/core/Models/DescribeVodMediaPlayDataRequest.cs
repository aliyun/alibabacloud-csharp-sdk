// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMediaPlayDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file (VideoId). You can specify this parameter to query all playback data of a media file. You can specify only one media ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the page that appears, view the media ID.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter in the response to the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation that you called to upload the audio or video file.</description></item>
        /// <item><description>Obtain the value of VideoId by calling the <a href="~~SearchMedia~~">SearchMedia</a> operation. This method is applicable to files that have been uploaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9ae2af636ca6c10412f44891fc****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The name of the metric. This parameter must be specified together with the <c>OrderType</c> parameter. You can specify this parameter to sort the returned data in ascending or descending order based on specific metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PlaySuccessVv</b>: the total number of views.</description></item>
        /// <item><description><b>PlayPerVv</b>: the average views per viewer.</description></item>
        /// <item><description><b>PlayDuration</b>: the total playback duration.</description></item>
        /// <item><description><b>PlayDurationPerUv</b>: the average playback duration per viewer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlaySuccessVv</para>
        /// </summary>
        [NameInMap("OrderName")]
        [Validation(Required=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para>The sort type. This parameter must be specified together with the <c>OrderName</c> parameter. You can specify this parameter to sort the returned data in ascending or descending order based on specific metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: The returned data is sorted in ascending order.</description></item>
        /// <item><description><b>DESC</b>: The returned data is sorted in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The operating system of the player. You can specify this parameter to query all playback data generated on a specific operating system. Valid values:</para>
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
        /// <para>The number of the page. You can specify a page number to return data from the specified page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The playback time. Specify the value in the yyyyMMdd format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query data only by day.</description></item>
        /// <item><description>You can query only data within the last 30 days.</description></item>
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
        /// <para>The region in which ApsaraVideo VOD is activated. You can specify this parameter to query all playback data generated only in a specific region. Valid values:</para>
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
        /// <para>The type of the player SDK. You can specify this parameter to query all playback data generated by using a specific type of player SDK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Native</b>: ApsaraVideo Player SDK for Android or ApsaraVideo Player SDK for iOS</description></item>
        /// <item><description><b>Web</b>: ApsaraVideo Player SDK for Web</description></item>
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
