// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// The ID of the DataWorks workspace. You can call the [ListProjects](https://help.aliyun.com/document_detail/2780068.html) operation to query the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the DataWorks workspace. You can call the [ListProjects](https://help.aliyun.com/document_detail/2780068.html) operation to query the name.
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
