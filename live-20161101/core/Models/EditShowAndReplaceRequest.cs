// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditShowAndReplaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The end time of the editing task. Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The valid values range from 0 to the value indicated by the total length of the episode.</para>
        /// </description></item>
        /// <item><description><para>By default, this parameter is set to the value that indicates the total length of the episode. The editing period cannot exceed the total length of the episode.</para>
        /// </description></item>
        /// <item><description><para>If you want to edit a VOD file from the 2nd second to the 5th second, set the StartTime parameter to 2.0 and the EndTime parameter to 5.0.</para>
        /// </description></item>
        /// </list>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the episode to be edited.</para>
        /// <remarks>
        /// <para> You can obtain the ID from the response parameter ShowId of the <a href="https://help.aliyun.com/document_detail/2848051.html">AddShowIntoShowList</a> operation.</para>
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
        /// <para>The start time of the editing task. Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The valid values range from 0 to the value indicated by the total length of the episode. By default, the editing task starts from the beginning of the episode. Default value: 0.0.</para>
        /// </description></item>
        /// <item><description><para>If you want to edit a VOD file from the 2nd second to the 5th second, set the StartTime parameter to 2.0 and the EndTime parameter to 5.0.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        /// <summary>
        /// <para>The storage information of the episode. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>StorageLocation</b>: the storage location of ApsaraVideo VOD.</description></item>
        /// <item><description><b>FileName</b>: the custom file name.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Editing outputs must be stored in the VOD bucket within the same account that is used to access both ApsaraVideo VOD and ApsaraVideo Live. For more information about how to obtain the storage location, see <a href="https://help.aliyun.com/document_detail/86097.html">Manage VOD resources</a>.</para>
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
