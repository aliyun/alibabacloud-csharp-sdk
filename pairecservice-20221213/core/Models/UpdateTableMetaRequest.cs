// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTableMetaRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<UpdateTableMetaRequestFields> Fields { get; set; }
        public class UpdateTableMetaRequestFields : TeaModel {
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("IsDimensionField")]
            [Validation(Required=false)]
            public bool? IsDimensionField { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("IsPartitionField")]
            [Validation(Required=false)]
            public string IsPartitionField { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Meaning")]
            [Validation(Required=false)]
            public string Meaning { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
