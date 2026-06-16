// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class EngineSearchRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048962366415007746</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to access the draft version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("grey")]
        [Validation(Required=false)]
        public bool? Grey { get; set; }

        /// <summary>
        /// <para>The query condition object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public EngineSearchRequestQuery Query { get; set; }
        public class EngineSearchRequestQuery : TeaModel {
            /// <summary>
            /// <para>The list of primary key IDs to exclude.<br>• Purpose: filters out previously viewed history records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;24234111&quot;,&quot;12423525&quot;]</para>
            /// </summary>
            [NameInMap("excludeIds")]
            [Validation(Required=false)]
            public List<string> ExcludeIds { get; set; }

            /// <summary>
            /// <para>The image query list.<br>• Only one image URL is supported. The maximum size of a single image is 10 MB. Supported formats: JPG, PNG, WEBP, and JPEG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;<a href="https://paperreview.oss-cn-hangzhou.aliyuncs.com/59dd424f-97ed-4855-942e-c961f1f5b67e.jpeg%22%5D">https://paperreview.oss-cn-hangzhou.aliyuncs.com/59dd424f-97ed-4855-942e-c961f1f5b67e.jpeg&quot;]</a></para>
            /// </summary>
            [NameInMap("imageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

            /// <summary>
            /// <para>The page number, starting from 1.<br>• Default value: <c>1</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of results returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The text query list.<br>• Only one text string is supported. The maximum length is 256 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;梅花图片&quot;]</para>
            /// </summary>
            [NameInMap("texts")]
            [Validation(Required=false)]
            public List<string> Texts { get; set; }

        }

        /// <summary>
        /// <para>This parameter does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e95ef4fbc28437db5008a910bd392a4</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user information object, used for subsequent user-perspective analysis.</para>
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public EngineSearchRequestUser User { get; set; }
        public class EngineSearchRequestUser : TeaModel {
            /// <summary>
            /// <para>The unique ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdfgnoevnor</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
