// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BasePunishLogResponse : TeaModel {
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("punished_at")]
        [Validation(Required=false)]
        public string PunishedAt { get; set; }

        [NameInMap("punishee")]
        [Validation(Required=false)]
        public BasePunishLogResponsePunishee Punishee { get; set; }
        public class BasePunishLogResponsePunishee : TeaModel {
            [NameInMap("content_hash")]
            [Validation(Required=false)]
            public BasePunishLogResponsePunisheeContentHash ContentHash { get; set; }
            public class BasePunishLogResponsePunisheeContentHash : TeaModel {
                [NameInMap("hash_hex_str")]
                [Validation(Required=false)]
                public string HashHexStr { get; set; }

                [NameInMap("hash_name")]
                [Validation(Required=false)]
                public string HashName { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("drive_id")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            [NameInMap("face_group_id")]
            [Validation(Required=false)]
            public string FaceGroupId { get; set; }

            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

            [NameInMap("share_id")]
            [Validation(Required=false)]
            public string ShareId { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("punishment_detail")]
        [Validation(Required=false)]
        public BasePunishLogResponsePunishmentDetail PunishmentDetail { get; set; }
        public class BasePunishLogResponsePunishmentDetail : TeaModel {
            [NameInMap("action_code")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            [NameInMap("investigation_status")]
            [Validation(Required=false)]
            public long? InvestigationStatus { get; set; }

            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("punish_reason")]
            [Validation(Required=false)]
            public string PunishReason { get; set; }

            [NameInMap("punishments")]
            [Validation(Required=false)]
            public List<PunishRule> Punishments { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        [NameInMap("punishment_id")]
        [Validation(Required=false)]
        public string PunishmentId { get; set; }

        [NameInMap("punishment_operation")]
        [Validation(Required=false)]
        public string PunishmentOperation { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
