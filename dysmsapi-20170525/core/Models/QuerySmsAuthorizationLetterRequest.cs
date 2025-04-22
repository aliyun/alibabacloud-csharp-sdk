// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAuthorizationLetterRequest : TeaModel {
        /// <summary>
        /// <para>委托授权书id列表</para>
        /// </summary>
        [NameInMap("AuthorizationLetterIdList")]
        [Validation(Required=false)]
        public List<long?> AuthorizationLetterIdList { get; set; }

        /// <summary>
        /// <para>授权方社会统一信用代码</para>
        /// 
        /// <b>Example:</b>
        /// <para>9****************A</para>
        /// </summary>
        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>签名名称（支持命中签名范围查询）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>授权书审核状态，INT:审核中，PASSED:审核通过</para>
        /// 
        /// <b>Example:</b>
        /// <para>PASSED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>授权书可用状态，VALID可用，INVALID不可用</para>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
