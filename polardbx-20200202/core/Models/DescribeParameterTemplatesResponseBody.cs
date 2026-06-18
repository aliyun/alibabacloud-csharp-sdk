// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParameterTemplatesResponseBodyData Data { get; set; }
        public class DescribeParameterTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The engine. Default value: polarx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The DPI engine version. Default value: 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The number of parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>218</para>
            /// </summary>
            [NameInMap("ParameterCount")]
            [Validation(Required=false)]
            public int? ParameterCount { get; set; }

            /// <summary>
            /// <para>The parameter list.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParameterTemplatesResponseBodyDataParameters> Parameters { get; set; }
            public class DescribeParameterTemplatesResponseBodyDataParameters : TeaModel {
                /// <summary>
                /// <para>The validation constraint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0|1]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is dynamic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: No.</description></item>
                /// <item><description><b>1</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dynamic")]
                [Validation(Required=false)]
                public int? Dynamic { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx hatp addition param</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>loose_enable_gts</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                public int? Revisable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UserChangable")]
                [Validation(Required=false)]
                public int? UserChangable { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
