// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateSearchIndexRequest : TeaModel {
        /// <summary>
        /// <para>The index configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("IndexConfig")]
        [Validation(Required=false)]
        public string IndexConfig { get; set; }

        /// <summary>
        /// <para>The index status. Default value: Active. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: activated.</description></item>
        /// <item><description>Deactive: deactivated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("IndexStatus")]
        [Validation(Required=false)]
        public string IndexStatus { get; set; }

        /// <summary>
        /// <para>The index type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mm: large model visual state. Used to describe complex visual features and actions in videos. This type helps identify and search for specific actions, movements, and events in videos, such as a soccer player scoring a goal or a basketball player getting injured.<remarks>
        /// <para>The shared instance type supports up to 1,000 hours of video. After the limit is exceeded, the system no longer performs large model visual state analysis.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>face: automatic face recognition. Used to describe facial features in videos. Through face recognition technology, faces in videos can be automatically tagged and searched.<remarks>
        /// <para>The shared instance type supports up to 1,000,000 face analyses. After the limit is exceeded, the system no longer performs face analysis.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>aiLabel: intelligent tagging. The intelligent tagging index type is used to describe subtitles, speech, and other content in videos. Through text and speech recognition technology, language information such as subtitles and dialogues in videos can be automatically extracted for tagging and searching. This helps users quickly search for and locate content related to specific topics or keywords in videos.</description></item>
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
        /// <para>The name of the search library.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify a search library name, the search index is created in the default IMS search library. Default value: ims-default-search-lib.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/2584455.html">QuerySearchLib</a> operation to query information about existing search libraries.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
