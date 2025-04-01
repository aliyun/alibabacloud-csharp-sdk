// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The compatible engine version. Valid values:</para>
        /// <para>Redis Open Source Edition: 5.0, 6.0, and 7.0. Tair DRAM-based instances: 5.0 and 6.0. Tair persistent memory-optimized instances: 6.0. Tair ESSD-based instances: 4.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The information about parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupTemplateListResponseBodyParameters> Parameters { get; set; }
        public class DescribeParameterGroupTemplateListResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The regular expression used to validate input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;\\d+\\s+\\d+\\s+\\d+&quot;</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the modification takes effect. Valid values: 0 and 1. A value of 0 indicates that the modification does not take effect. A value of 1 indicates that the modification takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public long? Effective { get; set; }

            /// <summary>
            /// <para>A divisor of the parameter. For a parameter of the integer or byte type, the valid values must be a multiple of Factor unless you set Factor to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Factor")]
            [Validation(Required=false)]
            public long? Factor { get; set; }

            /// <summary>
            /// <para>The description of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open AOF persistence mode</para>
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appendonly</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The default value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter can be modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0: The parameter cannot be modified.</b></description></item>
            /// <item><description><b>1</b>: The parameter can be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Revisable")]
            [Validation(Required=false)]
            public long? Revisable { get; set; }

            /// <summary>
            /// <para>Indicates whether the minor version can be changed. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportModifyForMinorVersion")]
            [Validation(Required=false)]
            public bool? SupportModifyForMinorVersion { get; set; }

            /// <summary>
            /// <para>The unit of the parameter value. Valid values: INT (ordinary integer), STRING (fixed string), and B (byte).</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D622714-AEDD-4609-9167-F5DDD3D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
