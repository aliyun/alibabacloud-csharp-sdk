// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitHotExpandPreCheckTaskRequest : TeaModel {
        /// <summary>
        /// The type of the database. Valid values:
        /// 
        /// *   RDS
        /// *   PolarDB
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// The name of the PolarDB-X database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableList")]
        [Validation(Required=false)]
        public List<string> TableList { get; set; }

    }

}
