// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFacegroupRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The face ID of the thumbnail of the face-based group. You can obtain the face ID from the **image_media_metadata** parameter in the returned results of the GetFile, ListFile, or SearchFile operation.
        /// </summary>
        [NameInMap("group_cover_face_id")]
        [Validation(Required=false)]
        public string GroupCoverFaceId { get; set; }

        /// <summary>
        /// The ID of the face-based group. You can call the ListFacegroups operation to query the group ID.
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the face-based group. The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The remarks. The remarks can be up to 128 characters in length.
        /// </summary>
        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
