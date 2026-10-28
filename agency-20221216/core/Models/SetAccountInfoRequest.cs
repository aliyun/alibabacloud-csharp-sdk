// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetAccountInfoRequest : TeaModel {
        /// <summary>
        /// <para>The nickname of the sub-account. For enterprise customers, this is the company name. For T2 partners, this is the partner name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的账号</para>
        /// </summary>
        [NameInMap("AccountNickname")]
        [Validation(Required=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// <para>The customer business manager. Maximum length: 50 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CustomerBd")]
        [Validation(Required=false)]
        public string CustomerBd { get; set; }

        /// <summary>
        /// <para>The description of the sub-account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试的账号</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The UID of the sub-account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
