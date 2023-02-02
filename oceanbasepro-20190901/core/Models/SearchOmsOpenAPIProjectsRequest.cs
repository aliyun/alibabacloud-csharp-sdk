// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SearchOmsOpenAPIProjectsRequest : TeaModel {
        /// <summary>
        /// The types of destination data sources.
        /// </summary>
        [NameInMap("DestDbTypes")]
        [Validation(Required=false)]
        public List<string> DestDbTypes { get; set; }

        /// <summary>
        /// The list of labels.
        /// </summary>
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        /// <summary>
        /// The page number, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page size, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The keyword for fuzzy search. A fuzzy search is performed based on the project ID and name.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The types of source data sources.
        /// </summary>
        [NameInMap("SourceDbTypes")]
        [Validation(Required=false)]
        public List<string> SourceDbTypes { get; set; }

        /// <summary>
        /// The list of project statuses.
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// The ID of the migration instance. Generally, if you want to create a project on a public cloud, you must first purchase a migration instance.
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
