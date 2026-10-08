// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainGroupListRequest : TeaModel {
        /// <summary>
        /// <para>The user-defined domain group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认分组</para>
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// <para>The language of error messages in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        /// <summary>
        /// <para>Specifies whether to show domain groups that are being deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowDeletingGroup")]
        [Validation(Required=false)]
        public bool? ShowDeletingGroup { get; set; }

        /// <summary>
        /// <para>The client IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
