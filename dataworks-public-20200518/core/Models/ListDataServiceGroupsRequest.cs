// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The gateway version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: API Gateway.</description></item>
        /// <item><description>2: Cloud-native API Gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApigwVersion")]
        [Validation(Required=false)]
        public int? ApigwVersion { get; set; }

        /// <summary>
        /// <para>The keyword in the business flow name. Substring matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test business flow</para>
        /// </summary>
        [NameInMap("GroupNameKeyword")]
        [Validation(Required=false)]
        public string GroupNameKeyword { get; set; }

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
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. You can obtain the ID from the PageResult.ProjectList[].ProjectId parameter in the response of the ListProjects operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
