// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServicePublishedApisRequest : TeaModel {
        /// <summary>
        /// <para>The keyword in the API name. This parameter filters APIs whose names contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My API name</para>
        /// </summary>
        [NameInMap("ApiNameKeyword")]
        [Validation(Required=false)]
        public string ApiNameKeyword { get; set; }

        /// <summary>
        /// <para>The keyword in the API path. This parameter filters APIs whose paths contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/</para>
        /// </summary>
        [NameInMap("ApiPathKeyword")]
        [Validation(Required=false)]
        public string ApiPathKeyword { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud ID of the API creator. This parameter filters APIs created by the specified user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>The example value is for format demonstration only. You can obtain a valid value from the PageResult.ProjectList[].ProjectId parameter in the response of the ListProjects operation. Before calling this operation, activate DataWorks Enterprise Edition or Ultimate Edition. Otherwise, a 403 Forbidden.Access error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the DataStudio page, click the username in the upper-right corner, and then choose Menu &gt; User Information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
