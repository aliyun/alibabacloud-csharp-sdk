// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAdvancedSearchFileRequest : TeaModel {
        /// <summary>
        /// The SQL statement used to query resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
