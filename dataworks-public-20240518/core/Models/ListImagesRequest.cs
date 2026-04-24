// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Official")]
        [Validation(Required=false)]
        public bool? Official { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<long?> ProjectIds { get; set; }

        [NameInMap("ProviderTypes")]
        [Validation(Required=false)]
        public List<string> ProviderTypes { get; set; }

        [NameInMap("SearchAll")]
        [Validation(Required=false)]
        public bool? SearchAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreatedTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Stages")]
        [Validation(Required=false)]
        public List<string> Stages { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("SupportedModules")]
        [Validation(Required=false)]
        public List<string> SupportedModules { get; set; }

        [NameInMap("SupportedTaskTypes")]
        [Validation(Required=false)]
        public List<string> SupportedTaskTypes { get; set; }

    }

}
