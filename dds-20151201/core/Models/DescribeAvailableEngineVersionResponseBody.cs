// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// The list of one or more engine versions to which an ApsaraDB for MongoDB instance can be upgraded.
        /// 
        /// >  An empty string is returned if the latest version is being used.
        /// </summary>
        [NameInMap("EngineVersions")]
        [Validation(Required=false)]
        public DescribeAvailableEngineVersionResponseBodyEngineVersions EngineVersions { get; set; }
        public class DescribeAvailableEngineVersionResponseBodyEngineVersions : TeaModel {
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public List<string> EngineVersion { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
