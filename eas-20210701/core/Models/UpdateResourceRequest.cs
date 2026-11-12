// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The new name of the resource group. The name cannot exceed 27 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iot</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The configuration options for the self-managed resource group.</para>
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public UpdateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class UpdateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// <para>The set of label key-value pairs for nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;key1&quot;: &quot;value1&quot;</para>
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// <para>The list of tolerations for node taints.</para>
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// <para>The effect.</para>
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
                /// <para>The relationship between the key name and the key value.</para>
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
