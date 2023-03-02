// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class MountDirectoryRequest : TeaModel {
        /// <summary>
        /// The ID of the directory that you want to add to the left-side navigation pane of DataAnalysis. This parameter is used together with the TargetType parameter.
        /// 
        /// For example, if you set the TargetType parameter to META_ALBUM, you must set the TargetId parameter to the ID of the related data album. You can call the [ListMetaCollections](~~469938~~) operation to obtain the ID of the data album. The ID is indicated by the QualifiedName parameter.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the directory that you want to add to the left-side navigation pane of DataAnalysis. Example: META_ALBUM, which indicates the data album.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
