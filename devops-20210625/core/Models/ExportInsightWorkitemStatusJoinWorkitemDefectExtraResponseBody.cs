// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExportInsightWorkitemStatusJoinWorkitemDefectExtraResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExportInsightWorkitemStatusJoinWorkitemDefectExtraResponseBodyResult> Result { get; set; }
        public class ExportInsightWorkitemStatusJoinWorkitemDefectExtraResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>65e836b981d758be7a25xxxx</para>
            /// </summary>
            [NameInMap("assignedToId")]
            [Validation(Required=false)]
            public string AssignedToId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65e836b981d758be7a25xxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("expectedWorkTime")]
            [Validation(Required=false)]
            public long? ExpectedWorkTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("extraId")]
            [Validation(Required=false)]
            public long? ExtraId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("extraIsDeleted")]
            [Validation(Required=false)]
            public string ExtraIsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("foundPhase")]
            [Validation(Required=false)]
            public int? FoundPhase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33166339200000</para>
            /// </summary>
            [NameInMap("gmtClosed")]
            [Validation(Required=false)]
            public long? GmtClosed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1713430241000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33166339200000</para>
            /// </summary>
            [NameInMap("gmtDue")]
            [Validation(Required=false)]
            public long? GmtDue { get; set; }

            [NameInMap("gmtFixed")]
            [Validation(Required=false)]
            public string GmtFixed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1714755985000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33166339200000</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33166339200000</para>
            /// </summary>
            [NameInMap("gmtTodo")]
            [Validation(Required=false)]
            public long? GmtTodo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>701615370</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public string IsArchived { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public string IsDone { get; set; }

            [NameInMap("isStupid")]
            [Validation(Required=false)]
            public string IsStupid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>61db9af2148974246bexxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a80a203a9078a7a1b1f2c6xxxx</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6135b21fb383ef39551cf02e,63466a385dc8531eebd764e9</para>
            /// </summary>
            [NameInMap("participantIds")]
            [Validation(Required=false)]
            public string ParticipantIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6732a29d846bf998dc09e7xxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("reopenNum")]
            [Validation(Required=false)]
            public int? ReopenNum { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            [NameInMap("seriousLevel")]
            [Validation(Required=false)]
            public int? SeriousLevel { get; set; }

            [NameInMap("solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>projex</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>731c83a40bbf3c2f080e07xxxx</para>
            /// </summary>
            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("stage")]
            [Validation(Required=false)]
            public int? Stage { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100005</para>
            /// </summary>
            [NameInMap("statusId")]
            [Validation(Required=false)]
            public string StatusId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public float? StoryPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9uy29901re573f561d69xxxx</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65e836b981d758be7a25xxxx</para>
            /// </summary>
            [NameInMap("verifierId")]
            [Validation(Required=false)]
            public string VerifierId { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{6a8cdda167415bea1506c7262c}</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public string Versions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("workTime")]
            [Validation(Required=false)]
            public long? WorkTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>636f661a612a945bbcdb4cxxxx</para>
            /// </summary>
            [NameInMap("workitemId")]
            [Validation(Required=false)]
            public string WorkitemId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
