// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackPathWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>When performing a paginated query, set the current page number. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. The default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>When performing a paginated query, set the maximum number of items per page. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Path name description.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path name descriptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
        /// </summary>
        [NameInMap("PathNameDesc")]
        [Validation(Required=false)]
        public string PathNameDesc { get; set; }

        /// <summary>
        /// <para>Path type.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>Whitelist name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WhitelistName")]
        [Validation(Required=false)]
        public string WhitelistName { get; set; }

    }

}
