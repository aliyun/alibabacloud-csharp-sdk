// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteQualityFollowerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the follower. You can call the <a href="https://help.aliyun.com/document_detail/174000.html">GetQualityFollower</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("FollowerId")]
        [Validation(Required=false)]
        public long? FollowerId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log in to the DataWorks console and go to the Workspace Management page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source where the partition expression is located. You can log in to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Data Quality page to obtain the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
