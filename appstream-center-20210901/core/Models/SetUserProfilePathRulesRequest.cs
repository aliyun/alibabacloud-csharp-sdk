// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class SetUserProfilePathRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a single app instance group. This parameter and AppInstanceGroupSetId are mutually exclusive. If a cloud app or cloud browser app instance group belongs to an enabled set, you must configure the rules at the set level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-0bi83v****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of an enabled app instance group set. This parameter and AppInstanceGroupId are mutually exclusive. You can set rules for up to 200 member app instance groups at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The region ID of the request. When you query or set rules for a specified app instance group, use the region where the target app instance group resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The JSON array string of the complete rule list. Each item uses <c>blackPath</c> to specify the excluded path and <c>whitePaths</c> to specify the relative paths that still require roaming within the excluded directory. The path type <c>file</c> indicates a file, and <c>folder</c> indicates a directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;blackPath&quot;:{&quot;path&quot;:&quot;AppData\\Local&quot;,&quot;type&quot;:&quot;folder&quot;},&quot;whitePaths&quot;:[{&quot;path&quot;:&quot;.\\Microsoft\\Office&quot;,&quot;type&quot;:&quot;folder&quot;}]}]</para>
        /// </summary>
        [NameInMap("UserProfilePathRules")]
        [Validation(Required=false)]
        public string UserProfilePathRules { get; set; }

        /// <summary>
        /// <para>The type of rule to set. Set this parameter to <c>AppInstanceGroup</c> when you configure rules for an app instance group or an app instance group set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroup</para>
        /// </summary>
        [NameInMap("UserProfileRuleType")]
        [Validation(Required=false)]
        public string UserProfileRuleType { get; set; }

    }

}
