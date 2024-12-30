// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileAddPermissionRequest : TeaModel {
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
        /// <para>The ID of the folder. If you want to authorize a user or group to access a team drive, set this parameter to root. If you want to authorize a user or group to access an individual drive, you cannot set this parameter to root.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4221bf6e6ab43c255edc4463bf3a6f5f5d317406</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The members that are authorized to access files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("member_list")]
        [Validation(Required=false)]
        public List<FilePermissionMember> MemberList { get; set; }

    }

}
