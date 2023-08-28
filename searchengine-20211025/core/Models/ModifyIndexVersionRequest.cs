// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexVersionRequest : TeaModel {
        /// <summary>
        /// ## Sample requests
        /// 
        /// ﻿
        /// 
        ///     PUT /openapi/ha3/instances/ha3_instance_nameclusters/test_cluster/index-version
        /// 
        /// ﻿
        /// 
        ///     [
        ///     ﻿
        ///       {
        ///     ﻿
        ///         "indexName": "index1",
        ///     ﻿
        ///         "version": "123456",
        ///     ﻿
        ///         "buildDeployId": "20201010"
        ///     ﻿
        ///       },
        ///     ﻿
        ///       {
        ///     ﻿
        ///         "indexName": "index1",
        ///     ﻿
        ///         "version": "123456",
        ///     ﻿
        ///         "buildDeployId": "20201010"
        ///     ﻿
        ///       }
        ///     ﻿
        ///     ]
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ModifyIndexVersionRequestBody> Body { get; set; }
        public class ModifyIndexVersionRequestBody : TeaModel {
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public string BuildDeployId { get; set; }

            /// <summary>
            /// WB01240825
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
