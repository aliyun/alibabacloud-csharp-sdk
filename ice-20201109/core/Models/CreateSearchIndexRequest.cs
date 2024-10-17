// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateSearchIndexRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("IndexConfig")]
        [Validation(Required=false)]
        public string IndexConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("IndexStatus")]
        [Validation(Required=false)]
        public string IndexStatus { get; set; }

        /// <summary>
        /// <para>The category of the index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mm: large visual model. You can use this model to describe complex visual features and identify and search for specific actions, movements, and events in videos, such as when athletes score a goal or get injured.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This feature is in the public preview phase. You can use this feature for free for 1,000 hours of videos.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>face: face recognition. You can use the face recognition technology to describe face characteristics and automatically mark or search for faces in videos.</description></item>
        /// <item><description>aiLabel: smart tagging. The smart tagging category is used to describe content such as subtitles and audio in videos. You can use the speech recognition technology to automatically extract, mark, and search for subtitles and dialog content from videos. This helps you quickly locate the video content that is related to specific topics or keywords.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
