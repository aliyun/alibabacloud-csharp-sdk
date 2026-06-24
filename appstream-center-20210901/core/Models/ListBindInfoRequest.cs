// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBindInfoRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para>If you specify this parameter, only the binding information of the specified applications is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The list of delivery group IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para>If you specify this parameter, only the binding information of the specified delivery groups is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The list of application instance IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para>If you specify this parameter, only the binding information of the specified application instances is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceIdList { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of user IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para>If you specify this parameter, only the binding information of the specified users is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// <para>The list of WUYING user IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para>If you specify this parameter, only the binding information of the specified WUYING users is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("WyIdList")]
        [Validation(Required=false)]
        public List<string> WyIdList { get; set; }

    }

}
