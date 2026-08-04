// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Valid values: 1 to 10,000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The user\&quot;s department. The value must be 1 to 128 characters long and can contain Chinese characters, letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (_), slashes (/), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The username for a fuzzy match. The value must be 1 to 128 characters long and can contain Chinese characters, letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("FuzzyUsername")]
        [Validation(Required=false)]
        public string FuzzyUsername { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The username for an exact match. The value must be 1 to 128 characters long and can contain Chinese characters, letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生@alibaba.com</para>
        /// </summary>
        [NameInMap("PreciseUsername")]
        [Validation(Required=false)]
        public string PreciseUsername { get; set; }

        /// <summary>
        /// <para>An array of user IDs.</para>
        /// </summary>
        [NameInMap("SaseUserIds")]
        [Validation(Required=false)]
        public List<string> SaseUserIds { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: The user is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: The user is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
