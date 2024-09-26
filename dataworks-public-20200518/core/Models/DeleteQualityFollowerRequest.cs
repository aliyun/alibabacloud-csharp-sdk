// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteQualityFollowerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the subscription relationship between the partition filter expression and the subscriber. You can call the <a href="https://help.aliyun.com/document_detail/174000.html">GetQualityFollower</a> operation to obtain the ID of the subscription relationship.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("FollowerId")]
        [Validation(Required=false)]
        public long? FollowerId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the compute engine or data source for which the partition filter expression is configured. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the rule configuration page of Data Quality page to obtain the name.</para>
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
