// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DirectNotifyChannel : TeaModel {
        /// <summary>
        /// <para>An array of recipient identifiers. The format of each identifier depends on the <c>type</c>. For example, if <c>type</c> is <c>email</c>, the identifiers are email addresses.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("identifiers")]
        [Validation(Required=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// <para>The notification channel type. For example, <c>sms</c> or <c>email</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
