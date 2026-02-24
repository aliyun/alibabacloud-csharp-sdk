// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeContact : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@company.com">zhangsan@company.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("emailVerify")]
        [Validation(Required=false)]
        public bool? EmailVerify { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("phoneCode")]
        [Validation(Required=false)]
        public string PhoneCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("phoneVerify")]
        [Validation(Required=false)]
        public bool? PhoneVerify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
