// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateRouteStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group. You can obtain the ID on the <b>Application Management</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the ID on the <b>Task Management</b> page in the SchedulerX console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54978</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The name of the routing policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-strategy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the <b>Namespace</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

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
        /// <para>Specifies whether to enable the routing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the routing policy.</description></item>
        /// <item><description><b>1</b>: enables the routing policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The details of the routing policy. The value is a JSON string. For more information about this parameter, see <b>the additional information about request parameters</b> below this table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;percentage&quot;:20,&quot;target&quot;:&quot;[\&quot;version1\&quot;]&quot;,&quot;targetType&quot;:&quot;label&quot;}]</para>
        /// </summary>
        [NameInMap("StrategyContent")]
        [Validation(Required=false)]
        public string StrategyContent { get; set; }

        /// <summary>
        /// <para>The type of the routing policy. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: routes by proportion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
