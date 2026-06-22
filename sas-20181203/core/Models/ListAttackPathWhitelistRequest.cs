// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackPathWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The page number when using paging. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page when using paging. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The path name description.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path name descriptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
        /// </summary>
        [NameInMap("PathNameDesc")]
        [Validation(Required=false)]
        public string PathNameDesc { get; set; }

        /// <summary>
        /// <para>The path type.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>The whitelist name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WhitelistName")]
        [Validation(Required=false)]
        public string WhitelistName { get; set; }

    }

}
