// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>本次请求所返回的最大记录条数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>返回读取到的数据位置，空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>本次请求条件下的数据总量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>用户列表。</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyUsers> Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>创建时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509338726362</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>备注。</para>
            /// 
            /// <b>Example:</b>
            /// <para>添加test用户</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Keytab内容Base64编码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>DBEDASDF==</para>
            /// </summary>
            [NameInMap("KeytabHex")]
            [Validation(Required=false)]
            public string KeytabHex { get; set; }

            /// <summary>
            /// <para>LDAP链接。
            /// ldap://emr-header-1.cluster-50018****:10389</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap://master-1-1.c-c6ce2d16d118****.cn-hangzhou.emr.aliyuncs.com:10389</para>
            /// </summary>
            [NameInMap("LdapUrl")]
            [Validation(Required=false)]
            public string LdapUrl { get; set; }

            /// <summary>
            /// <para>用户ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>125046002175****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>用户名称。
            /// test</para>
            /// 
            /// <b>Example:</b>
            /// <para>yun****</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
