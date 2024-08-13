// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectRequest : TeaModel {
        /// <summary>
        /// The thumbnail URL of the online editing project. If you leave this parameter empty and materials exist on the video track in the timeline, the thumbnail of the first material is used by default.
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the online editing project.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The region in which ApsaraVideo VOD is activated.
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
        /// The timeline of the online editing project in JSON format. For more information about the structure, see [Timeline](https://help.aliyun.com/document_detail/52839.html).
        /// 
        /// If you leave this parameter empty, an empty timeline is created and the duration of the online editing project is zero.
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// The title of the online editing project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
