// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class UpdateLabelTableRequest : TeaModel {
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<UpdateLabelTableRequestFields> Fields { get; set; }
        public class UpdateLabelTableRequestFields : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

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

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
