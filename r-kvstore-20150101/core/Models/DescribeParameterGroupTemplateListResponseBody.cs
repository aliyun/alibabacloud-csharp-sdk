// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The compatible version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The list of parameter details.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupTemplateListResponseBodyParameters> Parameters { get; set; }
        public class DescribeParameterGroupTemplateListResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The value range of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0|1]</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter has taken effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public long? Effective { get; set; }

            /// <summary>
            /// <para>The divisor factor. For integer and byte type parameters, the parameter value must not only fall within the valid range but also be a multiple of Factor (when Factor is not 0).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Factor")]
            [Validation(Required=false)]
            public long? Factor { get; set; }

            /// <summary>
            /// <para>The parameter description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable AOF persistence mode</para>
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
            /// <item><description><b>0</b>: The parameter cannot be modified.</description></item>
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
            /// <para>Indicates whether modification for minor versions is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportModifyForMinorVersion")]
            [Validation(Required=false)]
            public bool? SupportModifyForMinorVersion { get; set; }

            /// <summary>
            /// <para>The unit of the parameter value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INT</b>: a common integer.</description></item>
            /// <item><description><b>STRING</b>: a fixed string.</description></item>
            /// <item><description><b>B</b>: bytes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D622714-AEDD-4609-9167-F5DDD3D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
