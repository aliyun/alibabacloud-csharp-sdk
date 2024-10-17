// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the category.</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public AddCategoryResponseBodyCategory Category { get; set; }
        public class AddCategoryResponseBodyCategory : TeaModel {
            /// <summary>
            /// <para>The ID of the created category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The level of the category. A value of <b>0</b> indicates a level-1 category, a value of <b>1</b> indicates a level-2 category, and a value of <b>2</b> indicates a level-3 category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>The ID of the parent category. By default, if ParentId is left empty or less than 1, -1 is returned, which indicates that the created category is the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <para>The type of the category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: audio, video, and image files. This is the default value.</description></item>
            /// <item><description><b>material</b>: short video materials.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
