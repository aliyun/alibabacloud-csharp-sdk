// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableThemeLevelResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Entity")]
        [Validation(Required=false)]
        public GetMetaTableThemeLevelResponseBodyEntity Entity { get; set; }
        public class GetMetaTableThemeLevelResponseBodyEntity : TeaModel {
            /// <summary>
            /// <para>The level information.</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityLevel> Level { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityLevel : TeaModel {
                /// <summary>
                /// <para>The description of the level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The level ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                /// <summary>
                /// <para>The level name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>level1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The level type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: logical level.</description></item>
                /// <item><description>2: physical level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The theme information.</para>
            /// </summary>
            [NameInMap("Theme")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityTheme> Theme { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityTheme : TeaModel {
                /// <summary>
                /// <para>The theme type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: primary theme.</description></item>
                /// <item><description>2: secondary theme.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <para>The theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>theme1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the parent theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The theme ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public long? ThemeId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1324afdsfde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
