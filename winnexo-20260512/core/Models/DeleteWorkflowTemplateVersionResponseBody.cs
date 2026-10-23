// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class DeleteWorkflowTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current active version number. An empty value indicates that only a draft exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("effectiveVersion")]
        [Validation(Required=false)]
        public string EffectiveVersion { get; set; }

        /// <summary>
        /// <para>All remaining versions after deletion, sorted in descending order by version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DeleteWorkflowTemplateVersionResponseBodyItems> Items { get; set; }
        public class DeleteWorkflowTemplateVersionResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the user who created the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("createdByUserId")]
            [Validation(Required=false)]
            public long? CreatedByUserId { get; set; }

            /// <summary>
            /// <para>The description of the template for this version. This can be used for display when version v1 has no version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automatically generate weekly reports</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the version was created. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-19T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the version was modified. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-19T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The time when the version was submitted. The time is in the ISO 8601 format. This is empty for a draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-19T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("gmtSubmitted")]
            [Validation(Required=false)]
            public string GmtSubmitted { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is the only current active version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isEffective")]
            [Validation(Required=false)]
            public bool? IsEffective { get; set; }

            /// <summary>
            /// <para>The name of the template for this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The submitted version number on which this version is based. This is empty for a newly created v1 version. Saving or submitting a draft retains the original source version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("sourceVersion")]
            [Validation(Required=false)]
            public string SourceVersion { get; set; }

            /// <summary>
            /// <para>The version status. Valid values: DRAFT (draft) and SUBMITTED (submitted).</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of steps in this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("stepCount")]
            [Validation(Required=false)]
            public long? StepCount { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the version. This is empty for a draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("submittedByUserId")]
            [Validation(Required=false)]
            public long? SubmittedByUserId { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("updatedByUserId")]
            [Validation(Required=false)]
            public long? UpdatedByUserId { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The persisted version change description. An empty value indicates that no description is provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Added an approval step</para>
            /// </summary>
            [NameInMap("versionDescription")]
            [Validation(Required=false)]
            public string VersionDescription { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl_example</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
