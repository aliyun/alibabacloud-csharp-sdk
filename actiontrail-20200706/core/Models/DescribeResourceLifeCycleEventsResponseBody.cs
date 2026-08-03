// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeResourceLifeCycleEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The lifecycle events.<br>This field is returned as a JSON-serialized string. The string contains the hierarchical data for lifecycle event categories. Use a standard JSON deserialization tool for your programming language to parse the string into an array of objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;children&quot;:[{&quot;children&quot;:[{&quot;label&quot;:&quot;Create Events&quot;,&quot;labelEn&quot;:&quot;Create Events&quot;,&quot;value&quot;:&quot;Create,CreateInstance,RunInstances&quot;},{&quot;label&quot;:&quot;Delete Events&quot;,&quot;labelEn&quot;:&quot;Delete Events&quot;,&quot;value&quot;:&quot;DeleteInstance,DeleteInstances,Release&quot;}],&quot;label&quot;:&quot;ECS Instance&quot;,&quot;labelEn&quot;:&quot;ECS Instance&quot;,&quot;value&quot;:&quot;ACS::ECS::Instance&quot;}],&quot;label&quot;:&quot;Elastic Compute Service&quot;,&quot;labelEn&quot;:&quot;Elastic Compute Service&quot;,&quot;value&quot;:&quot;Ecs&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B10969CF-C743-55F8-9710-F0711504****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
