// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodeDependenciesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the node.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The data type of this parameter is Long in SDKs earlier than V8.0.0, and is String in SDKs of V8.0.0 and later versions. <b>The change does not affect the normal use of the SDKs. The parameter is still returned as the type defined in the SDKs.</b> When you upgrade an SDK to a version later than V8.0.0, a compilation error may occur due to the type change. In this case, you must manually change the data type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value of this parameter must be a positive integer. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can go to the Workspace Management page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> to obtain the workspace ID.</para>
        /// <para>This parameter is used to specify the DataWorks workspace for the API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
