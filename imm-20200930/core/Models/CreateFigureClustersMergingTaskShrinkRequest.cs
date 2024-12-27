// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFigureClustersMergingTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The ID of the source group. You must specify either From or Froms, but not both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-2ab85905-23ba-4632-b2d8-1c21cfe****</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The IDs of source clustering groups. You must specify either From or Froms, but not both. You can specify up to 100 task IDs.</para>
        /// </summary>
        [NameInMap("Froms")]
        [Validation(Required=false)]
        public string FromsShrink { get; set; }

        /// <summary>
        /// <para>The notification message configurations. For more information, see the &quot;Metadata indexing&quot; section of the <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a> topic.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The custom tags, which can be used to search for and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;val&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the destination clustering group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-4a3a71c1-c092-4788-8826-2f65d17****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <para>The custom data, which is returned in an asynchronous notification and facilitates notification management. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
