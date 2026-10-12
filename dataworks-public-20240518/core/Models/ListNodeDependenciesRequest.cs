// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodeDependenciesRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the data development node.</para>
        /// <remarks>
        /// <para>Notice: This field is of the Long type in SDK versions earlier than 8.0.0, and of the String type in SDK version 8.0.0 and later. <b>This change does not affect the normal use of the SDK. The parameter is still returned based on the data type defined in the SDK</b>. The type change may cause project compilation failures only when you upgrade the SDK across version 8.0.0. In this case, you must manually correct the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter specifies the DataWorks workspace used for this API call.</para>
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
