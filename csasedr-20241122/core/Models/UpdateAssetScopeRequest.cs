// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class UpdateAssetScopeRequest : TeaModel {
        /// <summary>
        /// <para>The asset scope ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1932</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The effective scope mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: All user groups.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Specified user groups.</description></item>
        /// <item><description><b>DeviceGroupNormal</b>: Specified device groups.</description></item>
        /// <item><description><b>DevTagNormal</b>: Specified device tags.</description></item>
        /// </list>
        /// <para>This field determines the meaning of MatchTargetIds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups, device tags, or tag groups.</para>
        /// </summary>
        [NameInMap("MatchTargetIds")]
        [Validation(Required=false)]
        public List<string> MatchTargetIds { get; set; }

    }

}
