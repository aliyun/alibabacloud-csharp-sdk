// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyData Data { get; set; }
        public class ListResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the marker after which the returned list begins.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZmN0X21vbnRoX3Rhb2Jhb19pbmRleCE=</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            /// <summary>
            /// <para>The list of resources.</para>
            /// </summary>
            [NameInMap("resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyDataResources> Resources { get; set; }
            public class ListResourcesResponseBodyDataResources : TeaModel {
                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The Base64-encoded 128-bit MD5 hash value of the HTTP request body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MACiECZtnLiNkNS1v5****=1</para>
                /// </summary>
                [NameInMap("contentMD5")]
                [Validation(Required=false)]
                public string ContentMD5 { get; set; }

                /// <summary>
                /// <para>The time when the resource was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-29T03:34:09Z</para>
                /// </summary>
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>res_1</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The time when the resource was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-18T06:15:05Z</para>
                /// </summary>
                [NameInMap("lastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The user who updated the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$<a href="mailto:xxx@test.aliyunid.com">xxx@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("lastUpdator")]
                [Validation(Required=false)]
                public string LastUpdator { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>res_1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1265860483008101</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The schema to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>schemaA</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>The size of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>file</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>py</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>jar</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>volumefile</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>table</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3b4ae16685836687916212e7850</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
