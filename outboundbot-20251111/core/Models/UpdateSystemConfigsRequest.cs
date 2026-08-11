// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateSystemConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The list of configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<UpdateSystemConfigsRequestConfigs> Configs { get; set; }
        public class UpdateSystemConfigsRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The system configuration name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>callableTime: the outbound job window.</description></item>
            /// <item><description>calleeDailyAttemptLimit: the maximum number of daily calls to a single callee number.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>callableTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configuration value.</para>
            /// <list type="bullet">
            /// <item><description><para>If Name is set to callableTime, a sample Value is [{&quot;beginTime&quot;:&quot;09:00:00&quot;,&quot;endTime&quot;:&quot;12:00:00&quot;},{&quot;beginTime&quot;:&quot;14:00:00&quot;,&quot;endTime&quot;:&quot;18:00:00&quot;}].</para>
            /// </description></item>
            /// <item><description><para>If Name is set to calleeDailyAttemptLimit, the Value is an integer from 1 to 50.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The configuration type ID. If ObjectType is set to INSTANCE, this parameter specifies the instance ID. If ObjectType is set to TENANT, this parameter specifies the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: instance level.</description></item>
        /// <item><description>TENANT: tenant level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
