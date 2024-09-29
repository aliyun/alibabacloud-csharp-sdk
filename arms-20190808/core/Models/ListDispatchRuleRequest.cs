// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDispatchRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the notification policy. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The type of notification policies to be queried. Valid values: <c>false</c> (default): notification policies created in Application Real-Time Monitoring Service (ARMS).</description></item>
        /// <item><description><c>true</c>: notification policies created in an external system.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You cannot use the ARMS console to modify the dispatch rules of a notification policy that is created in an external system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("System")]
        [Validation(Required=false)]
        public bool? System { get; set; }

    }

}
