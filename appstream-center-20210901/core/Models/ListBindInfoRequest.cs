// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBindInfoRequest : TeaModel {
        /// <summary>
        /// <para>The app IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, only the bindings of the specified apps are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The IDs of the delivery groups. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, only the bindings of the specified delivery groups are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The IDs of app instances. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, only the bindings of the specified app instances are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceIdList { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <c>1</c>. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value cannot be greater than <c>100</c>. Default value: <c>20</c>. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The user IDs. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, only the bindings of the specified users are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// <para>The IDs of the Alibaba Cloud Workspace users. You can specify 1 to 100 IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, only the bindings of the specified Alibaba Cloud Workspace users are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("WyIdList")]
        [Validation(Required=false)]
        public List<string> WyIdList { get; set; }

    }

}
