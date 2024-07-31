// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupGetOdpsRoleGroupsRequest : TeaModel {
        /// <summary>
        /// The name of the MaxCompute project. You can call the [DsgPlatformQueryProjectsAndSchemaFromMeta](https://help.aliyun.com/document_detail/2786303.html) operation to query a list of MaxCompute projects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
