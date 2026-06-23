// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteProjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can obtain the workspace ID from the Workspace Management page in the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
