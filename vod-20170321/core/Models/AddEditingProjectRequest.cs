// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The thumbnail URL of the online editing project. If you leave this parameter empty and materials exist on the video track in the timeline, the thumbnail of the first material is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://demo.aliyundoc.com/6AB4D0E1E1C74468883516C2349D1FC2-6-2.png">https://demo.aliyundoc.com/6AB4D0E1E1C74468883516C2349D1FC2-6-2.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline001desciption</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The region in which ApsaraVideo VOD is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Division")]
        [Validation(Required=false)]
        public string Division { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The timeline of the online editing project in JSON format. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/52839.html">Timeline</a>.</para>
        /// <para>If you leave this parameter empty, an empty timeline is created and the duration of the online editing project is zero.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;cc3308ac5006aed55a54328bc3443****&quot;},{&quot;MediaId&quot;:&quot;95948ddba24446b6aed5db985e78****&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
