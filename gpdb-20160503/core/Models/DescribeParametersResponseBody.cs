// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configuration parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The current value of the configuration parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10800000</para>
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance must be restarted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance must be restarted.</description></item>
            /// <item><description><b>false</b>: The instance does not need to be restarted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRestartInstance")]
            [Validation(Required=false)]
            public string ForceRestartInstance { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration parameter can be modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The parameter can be modified.</description></item>
            /// <item><description><b>false</b>: The parameter cannot be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsChangeableConfig")]
            [Validation(Required=false)]
            public string IsChangeableConfig { get; set; }

            /// <summary>
            /// <para>The value range of the configuration parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0-2147483647]</para>
            /// </summary>
            [NameInMap("OptionalRange")]
            [Validation(Required=false)]
            public string OptionalRange { get; set; }

            /// <summary>
            /// <para>The description of the configuration parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sets the maximum allowed duration of any statement，A value of 0 turns off the timeout.</para>
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// <para>The name of the configuration parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>statement_timeout</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The default value of the configuration parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10800000</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62506167-D284-562A-B7C2-0A**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
