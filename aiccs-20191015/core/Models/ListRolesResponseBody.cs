// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>Role information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRolesResponseBodyData> Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }

            /// <summary>
            /// <para>Role code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Creation Time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-03T20:25:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Role description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Admin</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ID of the group to which the role belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RoleGroupId")]
            [Validation(Required=false)]
            public long? RoleGroupId { get; set; }

            /// <summary>
            /// <para>Name of the role group to which the role belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>角色组名称</para>
            /// </summary>
            [NameInMap("RoleGroupName")]
            [Validation(Required=false)]
            public string RoleGroupName { get; set; }

            /// <summary>
            /// <para>Role ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// <para>Role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>企业管理员</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>Status code. A return value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
