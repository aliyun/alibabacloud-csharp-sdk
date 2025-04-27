// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDefaultCollectorConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BAE3C32-8E4A-47D6-B4B0-95B5DE643BF5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDefaultCollectorConfigurationsResponseBodyResult> Result { get; set; }
        public class ListDefaultCollectorConfigurationsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>key: log\n  title: Log file content\n  description: &gt;\n    Contains log file lines.\n  fields:\n ......</description></item>
            /// </list>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The name of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fields.yml</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

    }

}
