// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetScalingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33e39be9-3e5f-*********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group to which the application is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d8bb9d60-9**************</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The type of the scaling rule. You can leave this parameter empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALE_IN: scale-in rules</description></item>
        /// <item><description>SCALE_OUT: scale-out rules</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
