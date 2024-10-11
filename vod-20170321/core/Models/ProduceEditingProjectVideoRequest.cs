// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application service</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The thumbnail URL of the online editing project.</para>
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
        /// <para>description test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The video metadata. The value must be in JSON format. For more information about the parameter structure, see <a href="~~52839#title_rtf_ry5_gjp~~">MediaMetadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Description&quot;:&quot;video description&quot;,&quot;Title&quot;:&quot;userData test&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The configuration of video production. The value must be in the JSON format. For more information about the parameter structure, see <a href="~~52839#title-ybl-7cs-y7d~~">ProduceConfig</a>.</para>
        /// <remarks>
        /// <para> StorageLocation is required if you produce videos in a region other than China (Shanghai).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TemplateGroupId&quot;:&quot;6d11e25ea30a4c465435c74****&quot;}</para>
        /// </summary>
        [NameInMap("ProduceConfig")]
        [Validation(Required=false)]
        public string ProduceConfig { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project. You can use one of the following methods to obtain the ID of the online editing project:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Production Center</b> &gt; <b>Video Editing</b> to view the ID of the online editing project.</description></item>
        /// <item><description>Obtain the value of ProjectId from the response to the <a href="https://help.aliyun.com/document_detail/69048.html">AddEditingProject</a> operation.</description></item>
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
        /// <para>The timeline of the online editing project. The value must be in JSON format. For more information about the parameter structure, see <a href="~~52839#07bc7fe0f2xuh~~">Timeline</a>.</para>
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
        /// <para>editing project test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom configurations, such as the callback configuration. The value must be a JSON string. For more information about the parameter structure, see <a href="~~86952#title_vz7_xzs_0c5~~">UserData</a>.</para>
        /// <remarks>
        /// <para>The callback configurations take effect only after you specify an HTTP URL for receiving callback notifications and select the event types in the ApsaraVideo VOD console.</para>
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
