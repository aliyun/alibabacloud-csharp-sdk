// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteDataLevelPermissionRuleUsersRequest : TeaModel {
        /// <summary>
        /// <para>{
        /// &quot;ruleId&quot;: &quot;a5bb24da-<em><b>-a891683e14da&quot;, // The ID of the row-level permission rule.
        /// &quot;cubeId&quot;: &quot;7c7223ae-</b></em>-3c744528014b&quot;, // The ID of the dataset.
        /// &quot;delModel&quot;: {
        /// &quot;userGroups&quot;: [
        /// &quot;0d5fb19b-<em><b>-1248fc27ca51&quot;, // The ID of the user group to remove.
        /// &quot;3d2c23d4-</b></em>-f6390f325c2d&quot;
        /// ],
        /// &quot;users&quot;: [
        /// &quot;433&#x34;<em><b>358&quot;, // The ID of the user to remove.
        /// &quot;Huang</b></em>&#x33;fa822&quot;
        /// ]
        /// }
        /// }</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ruleId&quot;:&quot;a5bb24da-<em><b>-a891683e14da&quot;,&quot;cubeId&quot;:&quot;7c7223ae-</b></em>-3c744528014b&quot;,&quot;delModel&quot;:{&quot;userGroups&quot;:[&quot;0d5fb19b-<em><b>-1248fc27ca51&quot;,&quot;3d2c23d4-</b></em>-f6390f325c2d&quot;],&quot;users&quot;:[&quot;4334<em><b>358&quot;,&quot;Huang</b></em>3fa822&quot;]}}</para>
        /// </summary>
        [NameInMap("DeleteUserModel")]
        [Validation(Required=false)]
        public string DeleteUserModel { get; set; }

    }

}
