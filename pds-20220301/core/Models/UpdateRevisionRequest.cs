// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateRevisionRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether to permanently retain a version.
        /// 
        /// By default, this parameter is not specified, which indicates that you do not modify the permanent retention configuration of the version.
        /// </summary>
        [NameInMap("keep_forever")]
        [Validation(Required=false)]
        public bool? KeepForever { get; set; }

        /// <summary>
        /// The description of the version. The description can be up to 1,024 characters in length.
        /// 
        /// By default, this parameter is not specified, which indicates that you do not modify the description of the version.
        /// </summary>
        [NameInMap("revision_description")]
        [Validation(Required=false)]
        public string RevisionDescription { get; set; }

        /// <summary>
        /// The version ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
