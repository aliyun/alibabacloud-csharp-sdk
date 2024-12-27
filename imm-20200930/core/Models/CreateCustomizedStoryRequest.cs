// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCustomizedStoryRequest : TeaModel {
        /// <summary>
        /// <para>The cover image of the story. You can specify an image as the cover image of the custom story.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public CreateCustomizedStoryRequestCover Cover { get; set; }
        public class CreateCustomizedStoryRequestCover : TeaModel {
            /// <summary>
            /// <para>The URI of the cover image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket1/cover</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The custom labels. You can specify labels to help you identify and retrieve the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;: &quot;examplebucket&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The files of the story. You can specify up to 100 files in a custom story.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<CreateCustomizedStoryRequestFiles> Files { get; set; }
        public class CreateCustomizedStoryRequestFiles : TeaModel {
            /// <summary>
            /// <para>The URIs of the files.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;URI&quot;:&quot;oss://bucket1/file1&quot;}]</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the story.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <para>The subtype of the story. For information about valid subtypes, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Solo</para>
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>The type of the story. For information about valid types, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PeopleMemory</para>
        /// </summary>
        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
