// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFacegroupRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The face ID of the thumbnail of the face-based group. You can obtain the face ID from the <b>image_media_metadata</b> parameter in the returned results of the GetFile, ListFile, or SearchFile operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>face1</para>
        /// </summary>
        [NameInMap("group_cover_face_id")]
        [Validation(Required=false)]
        public string GroupCoverFaceId { get; set; }

        /// <summary>
        /// <para>The ID of the face-based group. You can call the ListFacegroups operation to query the group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group-abc</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the face-based group. The name can be up to 128 characters in length.</para>
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The remarks. The remarks can be up to 128 characters in length.</para>
        /// </summary>
        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
