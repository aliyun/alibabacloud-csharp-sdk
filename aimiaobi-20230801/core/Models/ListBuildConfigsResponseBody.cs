// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListBuildConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBuildConfigsResponseBodyData> Data { get; set; }
        public class ListBuildConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the preset is built-in</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuildIn")]
            [Validation(Required=false)]
            public bool? BuildIn { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-11 06:14:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Primary key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>主键ID，内置配置（buildIn=true）无该字段</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>List of available values for the tag</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<ListBuildConfigsResponseBodyDataKeywords> Keywords { get; set; }
            public class ListBuildConfigsResponseBodyDataKeywords : TeaModel {
                /// <summary>
                /// <para>Description of the preset tag</para>
                /// 
                /// <b>Example:</b>
                /// <para>新闻内容</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Key of the preset tag</para>
                /// 
                /// <b>Example:</b>
                /// <para>新闻内容</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>Tag key</para>
            /// 
            /// <b>Example:</b>
            /// <para>writingStyle</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>Tag description</para>
            /// 
            /// <b>Example:</b>
            /// <para>文体</para>
            /// </summary>
            [NameInMap("TagDescription")]
            [Validation(Required=false)]
            public string TagDescription { get; set; }

            /// <summary>
            /// <para>Content category. Valid values: media or government.</para>
            /// 
            /// <b>Example:</b>
            /// <para>media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Last update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-11 06:14:07</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Last updater</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA021073-17CE-5CCF-9FEB-93226C766887</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded. true indicates success. false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
