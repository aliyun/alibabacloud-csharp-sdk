// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SelectedComponentConfigDTO : TeaModel {
        /// <summary>
        /// <para>The property configuration list.</para>
        /// </summary>
        [NameInMap("AttributeConfigs")]
        [Validation(Required=false)]
        public List<SelectedComponentConfigDTOAttributeConfigs> AttributeConfigs { get; set; }
        public class SelectedComponentConfigDTOAttributeConfigs : TeaModel {
            /// <summary>
            /// <para>The upper and lower bound values, used for bounded properties.</para>
            /// </summary>
            [NameInMap("BoundedValue")]
            [Validation(Required=false)]
            public SelectedComponentConfigDTOAttributeConfigsBoundedValue BoundedValue { get; set; }
            public class SelectedComponentConfigDTOAttributeConfigsBoundedValue : TeaModel {
                /// <summary>
                /// <para>The lower bound.</para>
                /// </summary>
                [NameInMap("LowerBound")]
                [Validation(Required=false)]
                public SelectedComponentConfigDTOAttributeConfigsBoundedValueLowerBound LowerBound { get; set; }
                public class SelectedComponentConfigDTOAttributeConfigsBoundedValueLowerBound : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The upper bound.</para>
                /// </summary>
                [NameInMap("UpperBound")]
                [Validation(Required=false)]
                public SelectedComponentConfigDTOAttributeConfigsBoundedValueUpperBound UpperBound { get; set; }
                public class SelectedComponentConfigDTOAttributeConfigsBoundedValueUpperBound : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The property code.</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The property value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The component code.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The unique identifier of the component, used in multi-node and multi-disk scenarios.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
