// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PublishEdgeContainerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <ol>
        /// <item><description>Obtain the AppId by calling CreateEdgeContainerApp. 2) Obtain the VersionId by calling CreateEdgeContainerAppVersion (which requires the AppId). 3) The complete call chain is CreateEdgeContainerApp → CreateEdgeContainerAppVersion → PublishEdgeContainerAppVersion.</description></item>
        /// </ol>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a full release. This parameter takes effect only when PublishType is set to region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FullRelease")]
        [Validation(Required=false)]
        public bool? FullRelease { get; set; }

        /// <summary>
        /// <para>The publishing percentage. Valid values: <b>1 to 100</b>. Default value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// <para>The publishing environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prod</b>: production environment.</description></item>
        /// <item><description><b>staging</b>: staging environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("PublishEnv")]
        [Validation(Required=false)]
        public string PublishEnv { get; set; }

        /// <summary>
        /// <para>The publishing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>percentage</b>: Publish by percentage.</para>
        /// </description></item>
        /// <item><description><para><b>region</b>: Publish by region.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is not specified, percentage-based publishing is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>percentage</para>
        /// </summary>
        [NameInMap("PublishType")]
        [Validation(Required=false)]
        public string PublishType { get; set; }

        /// <summary>
        /// <para>The list of publishing regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The remarks. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test publish app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The time when the publishing starts. If this parameter is not specified, the current time is used by default.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-05T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The version ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ver-87962637161651****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
