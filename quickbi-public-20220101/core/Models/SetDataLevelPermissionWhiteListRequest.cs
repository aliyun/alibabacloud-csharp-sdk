// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>{ &quot;ruleType&quot;: &quot;ROW_LEVEL&quot;, // The row-level permission type. &quot;usersModel&quot;: { &quot;userGroups&quot;: [ &quot;0d5fb19b- <em><b>-1248 fc27ca51&quot;, // The ID of the user group. &quot;3d2c23d4-</b></em>-f6390f325c2d&quot; ], &quot;users&quot;: [ &quot;4334 <em><b>358&quot;, // Quick BI the UserID of the user. &quot;Huang</b></em>3fa822&quot; ] }, &quot;cubeId&quot;: &quot;7c7223ae-31d1-4d2f-b11f-3c744528014b&quot; }</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ruleType&quot;:&quot;ROW_LEVEL&quot;,&quot;usersModel&quot;:{&quot;userGroups&quot;:[&quot;26edcb76-<em><em><b>-bdbab78267cb&quot;,&quot;187e6dd5-1611-4cf7-a034-1a93bd5fecf9&quot;],&quot;users&quot;:[&quot;4334</b></em>358&quot;,&quot;Huang</em>**3fa822&quot;]},&quot;cubeId&quot;:&quot;7c7223ae-****44528014b&quot;}</para>
        /// </summary>
        [NameInMap("WhiteListModel")]
        [Validation(Required=false)]
        public string WhiteListModel { get; set; }

    }

}
