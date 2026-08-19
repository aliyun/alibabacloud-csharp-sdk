// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The thumbnail of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/6AB4D0E1E1C7446888351****.png">https://example.aliyundoc.com/6AB4D0E1E1C7446888351****.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud clip project description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata of the produced video in JSON format. For more information about the structure, see <a href="~~52839#title-rtf-ry5-gjp~~">MediaMetadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Description&quot;:&quot;Synthetic Video Description&quot;,&quot;Title&quot;:&quot;Synthetic userData test&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The production configuration in JSON format. For more information about the structure, see <a href="~~52839#title-ybl-7cs-y7d~~">ProduceConfig</a>.
        /// <notice>
        /// The StorageLocation field can be ignored when the file storage region is Shanghai. It is required when the file storage region is in other regions.
        /// </notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TemplateGroupId&quot;:&quot;6d11e25ea30a4c465435c74****&quot;}</para>
        /// </summary>
        [NameInMap("ProduceConfig")]
        [Validation(Required=false)]
        public string ProduceConfig { get; set; }

        /// <summary>
        /// <para>The online editing project ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>, choose <b>Production Center</b> &gt; <b>Video Editing</b>, and view the ID.</description></item>
        /// <item><description>Obtain the value of the ProjectId parameter returned when you call the <a href="https://help.aliyun.com/document_detail/69048.html">CreateEditingProject</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fb2101bf24b4cb318787dc****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The timeline of the online editing project in JSON format. For more information about the structure, see <a href="~~52839#07bc7fe0f2xuh~~">Timeline</a>.</para>
        /// <remarks>
        /// <para>Make sure that each VideoTrackClip object contains a valid MediaId. Otherwise, the request fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;cc3308ac59615a54328bc3443****&quot;},{&quot;MediaId&quot;:&quot;da87a9cff645cd88bc6d8326e4****&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud Clip Project Title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. The maximum length is 256 characters. The settings support message callbacks and other configurations. For more information about the structure, see <a href="~~86952#title-vz7-xzs-0c5~~">UserData</a>.</para>
        /// <remarks>
        /// <para>To use the message callback in this parameter, configure the HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;width&quot;:1280,&quot;id&quot;:&quot;028a8e56b1ebf6bb7afc74****&quot;,&quot;height&quot;:720},&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="https://example.aliyundoc.com/2016-08-15/proxy/httpcallback/testcallback/%22,%22CallbackType%22:%22http%22%7D%7D">https://example.aliyundoc.com/2016-08-15/proxy/httpcallback/testcallback/&quot;,&quot;CallbackType&quot;:&quot;http&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
