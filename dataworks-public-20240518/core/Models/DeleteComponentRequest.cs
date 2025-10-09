// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteComponentRequest : TeaModel {
        /// <summary>
        /// <para>The component ID. It can be used as a request parameter for querying the list of production studio components and modifying production studio components.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123123</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
