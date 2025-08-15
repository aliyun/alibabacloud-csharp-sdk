// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetTrailStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the status of a multi-account trail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Query the status of a multi-account trail.</description></item>
        /// <item><description>false: Query the status of a single-account trail. It is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// <para>The name must be 6 to 36 characters in length. The name must start with a lowercase letter and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// <remarks>
        /// <para>The name must be unique within your Alibaba Cloud account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
