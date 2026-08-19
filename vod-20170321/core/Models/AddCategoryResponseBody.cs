// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The media asset category information.</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public AddCategoryResponseBodyCategory Category { get; set; }
        public class AddCategoryResponseBodyCategory : TeaModel {
            /// <summary>
            /// <para>The category ID. This ID can be used as a request parameter for the <a href="~~UpdateCategory~~">UpdateCategory</a>, <a href="~~DeleteCategory~~">DeleteCategory</a>, and <a href="~~GetCategories~~">GetCategories</a> operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10020</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Comedy</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The category level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: level-0 category.</description></item>
            /// <item><description><b>1</b>: level-1 category.</description></item>
            /// <item><description><b>2</b>: level-2 category.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>The parent category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100012</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <para>The category type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: audio/video/image category.</description></item>
            /// <item><description><b>material</b>: short video material category.</description></item>
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
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
