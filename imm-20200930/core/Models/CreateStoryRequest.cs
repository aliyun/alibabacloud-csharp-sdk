// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateStoryRequest : TeaModel {
        /// <summary>
        /// <para>The address of the story. IMM filters candidate photos to generate a story based on the value of this parameter. This parameter takes effect only if you set StoryType to TravelMemory.</para>
        /// <remarks>
        /// <para> If you are located in Hong Kong (China), Macao (China), Taiwan (China), or overseas, you cannot specify an address in the Chinese mainland by using this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public AddressForStory Address { get; set; }

        /// <summary>
        /// <para>The custom ID. A custom ID of a generated story may differ from the value of ObjectID and can be utilized for subsequent retrieval and sorting of stories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels. Labels specify the custom information of the story. This enables retrieval based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;: &quot;examplebucket&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. For information about how to obtain the name of a dataset, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The maximum number of photo files in the story. The actual number of photo files ranges from the value of MinFileCount to the value of MaxFileCount. The value of this parameter must be an integer greater than the value of MinFileCount. To provide the desired effect, the algorithm limits the maximum number of photo files to 1,500. If you set MaxFileCount to a value greater than 1,500, this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxFileCount")]
        [Validation(Required=false)]
        public long? MaxFileCount { get; set; }

        /// <summary>
        /// <para>The minimum number of photo files in the story. The actual number of photo files ranges from the value of MinFileCount to the value of MaxFileCount. The value of this parameter must be an integer greater than 1. If the actual number of candidate photos is less than the value of this parameter, a null story is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinFileCount")]
        [Validation(Required=false)]
        public long? MinFileCount { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The topic name of the asynchronous reverse notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-topic</para>
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// <para>The ID of the story. This parameter is optional. If you leave this parameter empty, IMM assigns a unique identifier to the story. You can query and update a story based on its ID. You can also manually create an ID for a story. After you create an ID for a story, you must specify this parameter to pass the ID into the system. This way, IMM can record the ID as the unique identifier of the story. If you pass an existing ID into the system, IMM updates the story that corresponds to the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The end time of the photo collection for which you want to create the story. StoryStartTime and StoryEndTime form a time interval based on which IMM filters candidate photos to generate a story. The value must be a string in the RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-30T16:00:00Z</para>
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
        /// <para>The start time of the photo collection for which you want to create the story. StoryStartTime and StoryEndTime form a time interval based on which IMM filters candidate photos to generate a story. The value must be a string in the RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-12-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StoryStartTime")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        /// <summary>
        /// <para>The subtype of the story. For information about valid subtypes, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
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

        /// <summary>
        /// <para>The tags. You can specify this parameter in one of the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Specify tags as custom data, which is returned in messages provided by Simple Message Queue.</description></item>
        /// <item><description>Search for tasks by tag.</description></item>
        /// <item><description>Specify tags as variables in destination URIs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;val&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned as asynchronous notifications to facilitate notification management in your system. The maximum information length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
