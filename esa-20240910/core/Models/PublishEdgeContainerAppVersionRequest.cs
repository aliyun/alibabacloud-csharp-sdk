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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to fully release the version. This parameter takes effect only when PublishType is set to region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FullRelease")]
        [Validation(Required=false)]
        public bool? FullRelease { get; set; }

        /// <summary>
        /// <para>The release percentage. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Percentage")]
        [Validation(Required=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// <para>The environment to which you want to release the version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prod: the production environment.</description></item>
        /// <item><description>staging: the staging environment.</description></item>
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
        /// <para>Specifies how the version is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>percentage: releases the version by percentage.</description></item>
        /// <item><description>region: releases the version by region.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the version is released by percentage by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>percentage</para>
        /// </summary>
        [NameInMap("PublishType")]
        [Validation(Required=false)]
        public string PublishType { get; set; }

        /// <summary>
        /// <para>The regions to which the version is released.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The remarks. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test publish app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The time when the application version starts to be released. If you do not specify this parameter, the current time is used by default.</para>
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
