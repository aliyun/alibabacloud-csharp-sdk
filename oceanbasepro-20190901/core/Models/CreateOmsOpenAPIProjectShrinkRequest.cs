// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsOpenAPIProjectShrinkRequest : TeaModel {
        /// <summary>
        /// The business system identifier, which is optional and is a specific field of the Post message.
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The settings of the destination data source.
        /// </summary>
        [NameInMap("DestConfig")]
        [Validation(Required=false)]
        public string DestConfigShrink { get; set; }

        /// <summary>
        /// A collection of label IDs.
        /// </summary>
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

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
        /// The name of the project.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The settings of the source data source.
        /// </summary>
        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfigShrink { get; set; }

        /// <summary>
        /// The mappings for the synchronization objects.
        /// </summary>
        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

        /// <summary>
        /// The settings of synchronization steps.
        /// </summary>
        [NameInMap("TransferStepConfig")]
        [Validation(Required=false)]
        public string TransferStepConfigShrink { get; set; }

        /// <summary>
        /// The ID of the migration instance. Generally, if you want to create a project on a public cloud, you must first purchase a migration instance.
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
