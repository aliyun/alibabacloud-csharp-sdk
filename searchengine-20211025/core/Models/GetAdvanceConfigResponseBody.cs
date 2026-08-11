// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E45380E8-994A-5402-9806-F114B3295FCF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAdvanceConfigResponseBodyResult Result { get; set; }
        public class GetAdvanceConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content of the advanced configuration that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;url\&quot;:\&quot;<a href="http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar%5C%5C%22%7D">http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar\\&quot;}</a></para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The type of the configuration content. Valid values: FILE, GIT, HTTP, and ODPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The description of the advanced configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom remarks</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The files.</para>
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<GetAdvanceConfigResponseBodyResultFiles> Files { get; set; }
            public class GetAdvanceConfigResponseBodyResultFiles : TeaModel {
                /// <summary>
                /// <para>The file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/cluster</para>
                /// </summary>
                [NameInMap("fullPathName")]
                [Validation(Required=false)]
                public string FullPathName { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is a directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is a container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-pl32rf0****_qrs</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the advanced configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_index</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the advanced configuration. Valid values: drafting: The advanced configuration is in the draft state. used: The advanced configuration is being used. unused: The advanced configuration is not used. trash: The advanced configuration is being deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>used</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the advanced configuration was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
