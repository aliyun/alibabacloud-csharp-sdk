// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Story : TeaModel {
        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// <para>The story cover.</para>
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public File Cover { get; set; }

        /// <summary>
        /// <para>The time when the story was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The custom ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;val&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The fluster IDs.</para>
        /// </summary>
        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public List<string> FigureClusterIds { get; set; }

        /// <summary>
        /// <para>The story files.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The ID of the story object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The type of the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>story</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The ID of the owner to which the story belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102321002****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The time when the story ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("StoryEndTime")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        /// <summary>
        /// <para>The name of the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <para>The time when the story starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("StoryStartTime")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        /// <summary>
        /// <para>The subtype of the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImportantPerson</para>
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>The story type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PeopleMemory</para>
        /// </summary>
        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        /// <summary>
        /// <para>The time when the story was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
