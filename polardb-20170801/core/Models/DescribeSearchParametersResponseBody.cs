// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSearchParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB primary cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zex82f527he****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The Search engine version. This is not the MySQL version of the primary cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The type of the Search engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_search</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e3a24663-eee5-4009-b635-2e9e8d052e74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The visible parameters and their modification status.</para>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeSearchParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeSearchParametersResponseBodyRunningParameters : TeaModel {
            /// <summary>
            /// <para>The list of parameters.</para>
            /// </summary>
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeSearchParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeSearchParametersResponseBodyRunningParametersParameter : TeaModel {
                /// <summary>
                /// <para>The value validation rule of the template. The rule can be a numeric range, an enumeration, or a regular expression, and must be interpreted in combination with the data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[true\|false]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>The data type of the parameter value. Valid values: INT, DOUBLE, B/BYTE, MEMORY, PERCENT, TIME, BOOLEAN, and STRING. The MEMORY type supports percentages or capacities with units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BOOLEAN</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The default value of the current active template. This value is independent of the value modified by the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultParameterValue")]
                [Validation(Required=false)]
                public string DefaultParameterValue { get; set; }

                /// <summary>
                /// <para>The divisibility factor. If the value is not zero, the numeric value parsed based on the template type must be a multiple of this factor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Factor")]
                [Validation(Required=false)]
                public string Factor { get; set; }

                /// <summary>
                /// <para>Specifies whether a restart is required for the parameter to take effect. The value is true for static parameters and false for dynamic parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is modifiable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsModifiable")]
                [Validation(Required=false)]
                public bool? IsModifiable { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Parameter description</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prometheus.indices</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The modification status of the parameter. A value of Normal indicates that no modifications are pending. A value of Modifying indicates that the modification task is not completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ParameterStatus")]
                [Validation(Required=false)]
                public string ParameterStatus { get; set; }

                /// <summary>
                /// <para>The configuration value on the control plane. If a modification is in progress, the value to be applied is displayed. This value is not read from the kernel in real time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
