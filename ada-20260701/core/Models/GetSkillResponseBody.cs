// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the current caller can delete the Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>Indicates whether the current caller can modify the Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanModify")]
        [Validation(Required=false)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// <para>The creation time of the Skill, in Unix millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760000000000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The description in the current Skill main record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A Skill for performing code review and risk alerts</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The bundle download URL. Returned when a network type is specified, an accessible Artifact exists, and pre-signing succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/artifacts/code-review-v2.zip?signature=example">https://example.com/artifacts/code-review-v2.zip?signature=example</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The network type used to generate the download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("DownloadUrlNetwork")]
        [Validation(Required=false)]
        public string DownloadUrlNetwork { get; set; }

        /// <summary>
        /// <para>The Skill icon URL, sourced from the iconUrl in the metadata. This field may be empty if no icon is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/icons/code-review.png">https://example.com/icons/code-review.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The Skill metadata, mapped to the metadata field in the backend response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skillMd&quot;:&quot;# Code Review\nCheck code quality.&quot;,&quot;artifactId&quot;:&quot;artifact_example003&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The Skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the Skill is an official Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Official")]
        [Validation(Required=false)]
        public bool? Official { get; set; }

        /// <summary>
        /// <para>The request ID, used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Skill ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill_example123</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The current Skill status. Common values are DRAFT and PUBLISHED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time of the Skill, in Unix millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760000300000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The visibility of the current Skill. Common values are user and tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
