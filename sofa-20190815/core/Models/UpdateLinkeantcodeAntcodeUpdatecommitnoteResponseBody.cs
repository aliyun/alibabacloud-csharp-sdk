// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("DiscussionId")]
        [Validation(Required=false)]
        public long? DiscussionId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IsAward")]
        [Validation(Required=false)]
        public bool? IsAward { get; set; }

        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("NoteableId")]
        [Validation(Required=false)]
        public long? NoteableId { get; set; }

        [NameInMap("NoteableType")]
        [Validation(Required=false)]
        public string NoteableType { get; set; }

        [NameInMap("Outdated")]
        [Validation(Required=false)]
        public bool? Outdated { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResolvedAt")]
        [Validation(Required=false)]
        public string ResolvedAt { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("System")]
        [Validation(Required=false)]
        public bool? System { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("Discussions")]
        [Validation(Required=false)]
        public List<UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyDiscussions> Discussions { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyDiscussions : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("DiscussionId")]
            [Validation(Required=false)]
            public long? DiscussionId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsAward")]
            [Validation(Required=false)]
            public bool? IsAward { get; set; }

            [NameInMap("LatestStDiff")]
            [Validation(Required=false)]
            public string LatestStDiff { get; set; }

            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            [NameInMap("LineType")]
            [Validation(Required=false)]
            public string LineType { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("NoteableId")]
            [Validation(Required=false)]
            public long? NoteableId { get; set; }

            [NameInMap("NoteableType")]
            [Validation(Required=false)]
            public string NoteableType { get; set; }

            [NameInMap("Outdated")]
            [Validation(Required=false)]
            public bool? Outdated { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("ResolvedAt")]
            [Validation(Required=false)]
            public string ResolvedAt { get; set; }

            [NameInMap("ResolvedBy")]
            [Validation(Required=false)]
            public string ResolvedBy { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("StDiff")]
            [Validation(Required=false)]
            public string StDiff { get; set; }

            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Discussions")]
            [Validation(Required=false)]
            public List<string> Discussions { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

        }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyAuthor Author { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyAuthor : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("Bio")]
            [Validation(Required=false)]
            public string Bio { get; set; }
            [NameInMap("CanCreateGroup")]
            [Validation(Required=false)]
            public bool? CanCreateGroup { get; set; }
            [NameInMap("CanCreateProject")]
            [Validation(Required=false)]
            public bool? CanCreateProject { get; set; }
            [NameInMap("ColorSchemeId")]
            [Validation(Required=false)]
            public long? ColorSchemeId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("CurrentSignInAt")]
            [Validation(Required=false)]
            public string CurrentSignInAt { get; set; }
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }
            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PrivateToken")]
            [Validation(Required=false)]
            public string PrivateToken { get; set; }
            [NameInMap("ProjectsLimit")]
            [Validation(Required=false)]
            public long? ProjectsLimit { get; set; }
            [NameInMap("Registered")]
            [Validation(Required=false)]
            public bool? Registered { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }
            [NameInMap("WebsiteUrl")]
            [Validation(Required=false)]
            public string WebsiteUrl { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Identities")]
            [Validation(Required=false)]
            public List<string> Identities { get; set; }
        };

        [NameInMap("LatestStDiff")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyLatestStDiff LatestStDiff { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyLatestStDiff : TeaModel {
            [NameInMap("AddLineNum")]
            [Validation(Required=false)]
            public long? AddLineNum { get; set; }
            [NameInMap("Amode")]
            [Validation(Required=false)]
            public string Amode { get; set; }
            [NameInMap("AMode")]
            [Validation(Required=false)]
            public string AMode { get; set; }
            [NameInMap("BinaryFile")]
            [Validation(Required=false)]
            public bool? BinaryFile { get; set; }
            [NameInMap("Bmode")]
            [Validation(Required=false)]
            public string Bmode { get; set; }
            [NameInMap("BMode")]
            [Validation(Required=false)]
            public string BMode { get; set; }
            [NameInMap("CharsetName")]
            [Validation(Required=false)]
            public string CharsetName { get; set; }
            [NameInMap("CompareDiffId")]
            [Validation(Required=false)]
            public long? CompareDiffId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }
            [NameInMap("DelLineNum")]
            [Validation(Required=false)]
            public long? DelLineNum { get; set; }
            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }
            [NameInMap("HighlightedDiff")]
            [Validation(Required=false)]
            public string HighlightedDiff { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("NewFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }
            [NameInMap("NewPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }
            [NameInMap("OldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }
            [NameInMap("RenamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }
            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }
            [NameInMap("TooLarge")]
            [Validation(Required=false)]
            public bool? TooLarge { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
        };

        [NameInMap("ResolvedBy")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyResolvedBy ResolvedBy { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyResolvedBy : TeaModel {
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public long? AccessLevel { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("Bio")]
            [Validation(Required=false)]
            public string Bio { get; set; }
            [NameInMap("CanCreateGroup")]
            [Validation(Required=false)]
            public bool? CanCreateGroup { get; set; }
            [NameInMap("CanCreateProject")]
            [Validation(Required=false)]
            public bool? CanCreateProject { get; set; }
            [NameInMap("ColorSchemeId")]
            [Validation(Required=false)]
            public long? ColorSchemeId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("CurrentSignInAt")]
            [Validation(Required=false)]
            public string CurrentSignInAt { get; set; }
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }
            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PrivateToken")]
            [Validation(Required=false)]
            public string PrivateToken { get; set; }
            [NameInMap("ProjectsLimit")]
            [Validation(Required=false)]
            public long? ProjectsLimit { get; set; }
            [NameInMap("Registered")]
            [Validation(Required=false)]
            public bool? Registered { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }
            [NameInMap("WebsiteUrl")]
            [Validation(Required=false)]
            public string WebsiteUrl { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Identities")]
            [Validation(Required=false)]
            public List<string> Identities { get; set; }
        };

        [NameInMap("StDiff")]
        [Validation(Required=false)]
        public UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyStDiff StDiff { get; set; }
        public class UpdateLinkeantcodeAntcodeUpdatecommitnoteResponseBodyStDiff : TeaModel {
            [NameInMap("AddLineNum")]
            [Validation(Required=false)]
            public long? AddLineNum { get; set; }
            [NameInMap("Amode")]
            [Validation(Required=false)]
            public string Amode { get; set; }
            [NameInMap("AMode")]
            [Validation(Required=false)]
            public string AMode { get; set; }
            [NameInMap("BinaryFile")]
            [Validation(Required=false)]
            public bool? BinaryFile { get; set; }
            [NameInMap("Bmode")]
            [Validation(Required=false)]
            public string Bmode { get; set; }
            [NameInMap("BMode")]
            [Validation(Required=false)]
            public string BMode { get; set; }
            [NameInMap("CharsetName")]
            [Validation(Required=false)]
            public string CharsetName { get; set; }
            [NameInMap("CompareDiffId")]
            [Validation(Required=false)]
            public long? CompareDiffId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }
            [NameInMap("DelLineNum")]
            [Validation(Required=false)]
            public long? DelLineNum { get; set; }
            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }
            [NameInMap("HighlightedDiff")]
            [Validation(Required=false)]
            public string HighlightedDiff { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("NewFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }
            [NameInMap("NewPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }
            [NameInMap("OldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }
            [NameInMap("RenamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }
            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }
            [NameInMap("TooLarge")]
            [Validation(Required=false)]
            public bool? TooLarge { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
        };

    }

}
