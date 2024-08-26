// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class KnowledgeFile : TeaModel {
        [NameInMap("creator_id")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        [NameInMap("file_category")]
        [Validation(Required=false)]
        public string FileCategory { get; set; }

        [NameInMap("file_created_at")]
        [Validation(Required=false)]
        public long? FileCreatedAt { get; set; }

        [NameInMap("file_creator_id")]
        [Validation(Required=false)]
        public string FileCreatorId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("file_image_time")]
        [Validation(Required=false)]
        public long? FileImageTime { get; set; }

        [NameInMap("file_last_modifier_id")]
        [Validation(Required=false)]
        public string FileLastModifierId { get; set; }

        [NameInMap("file_last_modifier_type")]
        [Validation(Required=false)]
        public string FileLastModifierType { get; set; }

        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("file_name_path")]
        [Validation(Required=false)]
        public string FileNamePath { get; set; }

        [NameInMap("file_size")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("file_updated_at")]
        [Validation(Required=false)]
        public long? FileUpdatedAt { get; set; }

        [NameInMap("joined_at")]
        [Validation(Required=false)]
        public long? JoinedAt { get; set; }

        [NameInMap("knowledge_base_id")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        [NameInMap("knowledge_category_id")]
        [Validation(Required=false)]
        public string KnowledgeCategoryId { get; set; }

        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
