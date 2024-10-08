// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The new name of the resource group after the update. The name can be up to 27 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iot</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The configuration items of the self-managed resource group.</para>
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public UpdateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class UpdateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// <para>Tag tag key-value pairs for nodes.</para>
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// <para>Tolerations for nodes.</para>
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// <para>The effect.
                /// Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PreferNoSchedule</description></item>
                /// <item><description>NoSchedule</description></item>
                /// <item><description>NoExecute</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSchedule</para>
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Relationship between key names and key values.
                /// Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Equal</description></item>
                /// <item><description>Exists</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The key value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
