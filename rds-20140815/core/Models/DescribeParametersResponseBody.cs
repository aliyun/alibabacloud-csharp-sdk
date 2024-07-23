// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameters that are being synchronized.</para>
        /// <remarks>
        /// <para>After you modify and submit the parameters, you must wait for the parameters to be synchronized to the instance. After the synchronization, you can delete the parameters from the list.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyConfigParameters ConfigParameters { get; set; }
        public class DescribeParametersResponseBodyConfigParameters : TeaModel {
            [NameInMap("DBInstanceParameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyConfigParametersDBInstanceParameter> DBInstanceParameter { get; set; }
            public class DescribeParametersResponseBodyConfigParametersDBInstanceParameter : TeaModel {
                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter sets the default fill factor value at the server scope. A fill factor is provided to optimize index data storage and performance.</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fill factor</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.5</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The information about the parameter template.</para>
        /// </summary>
        [NameInMap("ParamGroupInfo")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyParamGroupInfo ParamGroupInfo { get; set; }
        public class DescribeParametersResponseBodyParamGroupInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rpg-sys-01040401010200</para>
            /// </summary>
            [NameInMap("ParamGroupId")]
            [Validation(Required=false)]
            public string ParamGroupId { get; set; }

            /// <summary>
            /// <para>The description of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync_binlog=1000, innodb_flush_log_at_trx_commit=2, async</para>
            /// </summary>
            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            /// <summary>
            /// <para>The name of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_innodb_8.0_basic_normal_high</para>
            /// </summary>
            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

            /// <summary>
            /// <para>The type of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ParameterGroupType")]
            [Validation(Required=false)]
            public string ParameterGroupType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters that are in use.</para>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("DBInstanceParameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyRunningParametersDBInstanceParameter> DBInstanceParameter { get; set; }
            public class DescribeParametersResponseBodyRunningParametersDBInstanceParameter : TeaModel {
                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ParameterDefaultValue")]
                [Validation(Required=false)]
                public string ParameterDefaultValue { get; set; }

                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter sets the default fill factor value at the server scope. A fill factor is provided to optimize index data storage and performance.</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fill factor</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

                /// <summary>
                /// <para>The valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1~100</para>
                /// </summary>
                [NameInMap("ParameterValueRange")]
                [Validation(Required=false)]
                public string ParameterValueRange { get; set; }

            }

        }

    }

}
