// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>The accessibility:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: Visible to all members.</para>
        /// </description></item>
        /// <item><description><para>Private: Visible only to the creator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The image name, used for fuzzy search.</para>
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
        /// <para>The page size.</para>
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
        public List<long?> ProjectIds { get; set; }

        /// <summary>
        /// <para>The list of image provider types.</para>
        /// </summary>
        [NameInMap("ProviderTypes")]
        [Validation(Required=false)]
        public List<string> ProviderTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to search all images.</para>
        /// </summary>
        [NameInMap("SearchAll")]
        [Validation(Required=false)]
        public bool? SearchAll { get; set; }

        /// <summary>
        /// <para>The list of sort fields. You can sort by scheduled time, start time, and other fields. The format is &quot;SortField+SortOrder(Desc/Asc)&quot;, where Asc is the default and can be omitted. Valid values of sort fields:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime (Desc/Asc): The creation time.</para>
        /// </description></item>
        /// <item><description><para>Name (Desc/Asc): The image name.
        /// Default value: CreateTime Asc.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreatedTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of image publish stages to query.</para>
        /// </summary>
        [NameInMap("Stages")]
        [Validation(Required=false)]
        public List<string> Stages { get; set; }

        /// <summary>
        /// <para>The list of image statuses to query.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>The list of supported modules.</para>
        /// </summary>
        [NameInMap("SupportedModules")]
        [Validation(Required=false)]
        public List<string> SupportedModules { get; set; }

        /// <summary>
        /// <para>The list of supported task types.</para>
        /// </summary>
        [NameInMap("SupportedTaskTypes")]
        [Validation(Required=false)]
        public List<string> SupportedTaskTypes { get; set; }

    }

}
