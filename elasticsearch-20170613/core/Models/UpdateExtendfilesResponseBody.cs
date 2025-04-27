// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateExtendfilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpdateExtendfilesResponseBodyResult> Result { get; set; }
        public class UpdateExtendfilesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The size of the driver file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1853083</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The name of the driver file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql-connector-java-6.0.2.jar</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source of the driver file. This parameter is fixed as ORIGIN, which indicates that the driver file is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORIGIN</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

    }

}
