// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditShowAndReplaceRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter in the response.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page is the production studio ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The end time of the video clip. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The valid range of the clip time is 0 to the total duration of the show.</description></item>
        /// <item><description>The default value is the end time of the video-on-demand file. The value cannot exceed the total duration of the show.</description></item>
        /// <item><description>For example, to clip a video-on-demand file from the 2nd second to the 5th second, set StartTime to 2.0 and EndTime to 5.0.</description></item>
        /// <item><description>You must specify at least one of StartTime and EndTime.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public float? EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the show to be clipped. The referenced show must be of the video-on-demand material type (ResourceInfo.ResourceType=vod with a valid resourceId).</para>
        /// <remarks>
        /// <para>Obtain the ShowId value from the response parameters of the <a href="https://help.aliyun.com/document_detail/2848051.html">AddShowIntoShowList</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        /// <summary>
        /// <para>The start time of the video clip. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The valid range of the clip time is 0 to the total duration of the show. - By default, the clip starts from the beginning of the video-on-demand file. Value: 0.0.</description></item>
        /// <item><description>For example, to clip a video-on-demand file from the 2nd second to the 5th second, set StartTime to 2.0 and EndTime to 5.0.</description></item>
        /// <item><description>You must specify at least one of StartTime and EndTime.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        /// <summary>
        /// <para>The storage information. This parameter is required. Description:</para>
        /// <list type="bullet">
        /// <item><description><b>StorageLocation</b>: the video-on-demand storage address of the user.</description></item>
        /// <item><description><b>FileName</b>: the custom file name.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The video clip storage address must be a video-on-demand storage address under the same account. To obtain the video-on-demand storage address, see <a href="https://help.aliyun.com/document_detail/86097.html">Storage management</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;StorageLocation&quot;:&quot;<em><b>bucket</b></em>&quot;, &quot;FileName&quot;:&quot;EditFile****.mp4&quot; }</para>
        /// </summary>
        [NameInMap("StorageInfo")]
        [Validation(Required=false)]
        public string StorageInfo { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900a2b2r8-13c2-****-88f2-75e4a07c1ed9</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
