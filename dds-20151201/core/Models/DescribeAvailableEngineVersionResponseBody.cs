// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of one or more engine versions to which an ApsaraDB for MongoDB instance can be upgraded.</para>
        /// <remarks>
        /// <para> An empty string is returned if the latest version is being used.</para>
        /// </remarks>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52507B6B-003B-47A3-A0A3-9FE992C7A243</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
