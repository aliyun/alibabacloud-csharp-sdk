// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImagesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The accessibility of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: The image is visible to all users.</description></item>
        /// <item><description>Private: The image is visible only to the creator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The image name used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is an official image.</para>
        /// </summary>
        [NameInMap("Official")]
        [Validation(Required=false)]
        public bool? Official { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of workspace IDs.</para>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of image reference data types.</para>
        /// </summary>
        [NameInMap("ProviderTypes")]
        [Validation(Required=false)]
        public string ProviderTypesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to search for all images.</para>
        /// </summary>
        [NameInMap("SearchAll")]
        [Validation(Required=false)]
        public bool? SearchAll { get; set; }

        /// <summary>
        /// <para>The list of sort fields. Fields such as scheduled time and start time are supported. The format is &quot;sort field + sort order (Desc/Asc)&quot;. Asc can be omitted. Valid values for sort fields:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime (Desc/Asc): creation time.</description></item>
        /// <item><description>Name (Desc/Asc): image name.
        /// Default value: CreateTime Asc.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreatedTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of image publishing stages to query.</para>
        /// </summary>
        [NameInMap("Stages")]
        [Validation(Required=false)]
        public string StagesShrink { get; set; }

        /// <summary>
        /// <para>The list of image statuses to query.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

        /// <summary>
        /// <para>The list of supported modules.</para>
        /// </summary>
        [NameInMap("SupportedModules")]
        [Validation(Required=false)]
        public string SupportedModulesShrink { get; set; }

        /// <summary>
        /// <para>The list of supported task types.</para>
        /// </summary>
        [NameInMap("SupportedTaskTypes")]
        [Validation(Required=false)]
        public string SupportedTaskTypesShrink { get; set; }

    }

}
