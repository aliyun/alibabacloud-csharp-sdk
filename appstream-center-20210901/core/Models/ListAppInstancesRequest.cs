// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-4p5f8tj16yb8b****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-azn3kmwruh1vl****</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The list of application instance IDs. A maximum of 100 IDs can be specified.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AppInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to query information about deleted instances. If this parameter is set to true, the AppInstanceIdList parameter is required. Otherwise, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDeleted")]
        [Validation(Required=false)]
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// <para>The page number of the query results to display. Default value: <c>1</c>. Specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page. Maximum value: <c>100</c>. Default value: <c>20</c>. Specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of application instance statuses.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The list of user IDs. A maximum of 100 IDs can be specified.</para>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
