// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddDataLevelPermissionRuleUsersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ruleId&quot;:&quot;a5bb24da-<em><b>-a891683e14da&quot;,&quot;cubeId&quot;:&quot;7c7223ae-</b></em>-3c744528014b&quot;,&quot;addModel&quot;:{&quot;userGroups&quot;:[&quot;0d5fb19b-<em><b>-1248fc27ca51&quot;,&quot;3d2c23d4-</b></em>-f6390f325c2d&quot;],&quot;users&quot;:[&quot;4334<em><b>358&quot;,&quot;Huang</b></em>3fa822&quot;]}}</para>
        /// </summary>
        [NameInMap("AddUserModel")]
        [Validation(Required=false)]
        public string AddUserModel { get; set; }

    }

}
