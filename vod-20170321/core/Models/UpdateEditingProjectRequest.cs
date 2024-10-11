// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The thumbnail URL of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.com/6AB4D0E1E1C7446888</b></b>.png</para>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ee4b97e27*****b525142a6b2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The timeline of the online editing project. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/52839.html">Timeline</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;cc3308ac500c<em><b><b>a54328bc3443&quot;},{&quot;MediaId&quot;:&quot;da87a9cff64</b></b></em>d88bc6d8326e4&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
