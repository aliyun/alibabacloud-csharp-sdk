// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupGetOdpsRoleGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the MaxCompute project. You can call the <a href="https://help.aliyun.com/document_detail/2786303.html">DsgPlatformQueryProjectsAndSchemaFromMeta</a> operation to query a list of MaxCompute projects.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
