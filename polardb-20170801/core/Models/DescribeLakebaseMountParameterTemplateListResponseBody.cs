// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLakebaseMountParameterTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameter templates.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeLakebaseMountParameterTemplateListResponseBodyParameters> Parameters { get; set; }
        public class DescribeLakebaseMountParameterTemplateListResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The parameter description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Auto-increment offset</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter takes effect dynamically. Valid values: 1 and 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDynamic")]
            [Validation(Required=false)]
            public string IsDynamic { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter can be modified by users. Valid values: 1 and 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsUserChangeable")]
            [Validation(Required=false)]
            public string IsUserChangeable { get; set; }

            /// <summary>
            /// <para>The value range or valid values. Example: [0-3600].</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0-3600]</para>
            /// </summary>
            [NameInMap("Optional")]
            [Validation(Required=false)]
            public string Optional { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_increment_offset</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
