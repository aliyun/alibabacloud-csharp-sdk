// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersInRecycleBinRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition that is used to query information about a specified RAM user in the recycle bin.</para>
        /// <para>You must specify this parameter in the <c>UserPrincipalName eq &lt;username&gt;@&lt;AccountAlias&gt;.onaliyun.com</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserPrincipalName eq <a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The <c>marker</c>. If part of a previous response is truncated, you can use this parameter to obtain the truncated part.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The number of entries to return. If a response is truncated because it reaches the value of <c>MaxItems</c>, the value of <c>IsTruncated</c> will be true.</para>
        /// <para>Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

    }

}
