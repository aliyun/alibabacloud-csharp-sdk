// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1s826a1up******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine that the clusters runs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine. </para>
        /// <list type="bullet">
        /// <item><description>Valid values for the MySQL database engine:   <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Valid value for the PostgreSQL database engine:    <list type="bullet">
        /// <item><description><b>11</b></description></item>
        /// <item><description><b>14</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Valid value for the Oracle database engine:  <b>11</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The cluster engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The number of parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParameterNumbers")]
        [Validation(Required=false)]
        public string ParameterNumbers { get; set; }

        /// <summary>
        /// <para>A comparison of parameters between the source RDS instance and the destination PolarDB cluster.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyParameters : TeaModel {
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyParametersParameters> Parameters { get; set; }
            public class DescribeDBClusterParametersResponseBodyParametersParameters : TeaModel {
                /// <summary>
                /// <para>Indicates whether the source and current parameters have the same value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsEqual")]
                [Validation(Required=false)]
                public string IsEqual { get; set; }

                /// <summary>
                /// <para>Indicate whether the parameter is a primary parameter of the destination cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The parameter is a primary parameter of the destination cluster.</description></item>
                /// <item><description><b>0</b>: The parameter is not a primary parameter of the destination cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsInstancePolarDBKey")]
                [Validation(Required=false)]
                public string IsInstancePolarDBKey { get; set; }

                /// <summary>
                /// <para>Indicate whether the parameter is a primary parameter of the source instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The parameter is a primary parameter of the source instance.</description></item>
                /// <item><description><b>0</b>: The parameter is not a primary parameter of the source instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsInstanceRdsKey")]
                [Validation(Required=false)]
                public string IsInstanceRdsKey { get; set; }

                /// <summary>
                /// <para>Indicate whether the parameter is a primary parameter of the destination cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The parameter is a primary parameter of the destination cluster.</description></item>
                /// <item><description><b>0</b>: The parameter is not a primary parameter of the destination cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsPolarDBKey")]
                [Validation(Required=false)]
                public string IsPolarDBKey { get; set; }

                /// <summary>
                /// <para>Indicate whether the parameter is a primary parameter of the source instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The parameter is a primary parameter of the source instance.</description></item>
                /// <item><description><b>0</b>: The parameter is not a primary parameter of the source instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsRdsKey")]
                [Validation(Required=false)]
                public string IsRdsKey { get; set; }

                /// <summary>
                /// <para>The description of the parameter of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The server\&quot;s default character set.</para>
                /// </summary>
                [NameInMap("distParameterDescription")]
                [Validation(Required=false)]
                public string DistParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>character_set_server</para>
                /// </summary>
                [NameInMap("distParameterName")]
                [Validation(Required=false)]
                public string DistParameterName { get; set; }

                /// <summary>
                /// <para>The valid values of the parameter of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>utf8</description></item>
                /// <item><description>gbk</description></item>
                /// </list>
                /// </summary>
                [NameInMap("distParameterOptional")]
                [Validation(Required=false)]
                public string DistParameterOptional { get; set; }

                /// <summary>
                /// <para>The value of the parameter of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("distParameterValue")]
                [Validation(Required=false)]
                public string DistParameterValue { get; set; }

                /// <summary>
                /// <para>The description of the parameter of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The server\&quot;s default character set.</para>
                /// </summary>
                [NameInMap("rdsParameterDescription")]
                [Validation(Required=false)]
                public string RdsParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>character_set_server</para>
                /// </summary>
                [NameInMap("rdsParameterName")]
                [Validation(Required=false)]
                public string RdsParameterName { get; set; }

                /// <summary>
                /// <para>The valid values of the parameter of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>utf8</description></item>
                /// <item><description>gbk</description></item>
                /// </list>
                /// </summary>
                [NameInMap("rdsParameterOptional")]
                [Validation(Required=false)]
                public string RdsParameterOptional { get; set; }

                /// <summary>
                /// <para>The value of the parameter of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("rdsParameterValue")]
                [Validation(Required=false)]
                public string RdsParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBEAA83D-1734-42E3-85E3-E25F6E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters of the PolarDB cluster.</para>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeDBClusterParametersResponseBodyRunningParametersParameter : TeaModel {
                /// <summary>
                /// <para>The valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[utf8|latin1|gbk|utf8mb4]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>The data type of the parameter value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INT</b></description></item>
                /// <item><description><b>STRING</b></description></item>
                /// <item><description><b>B</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INT</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("DefaultParameterValue")]
                [Validation(Required=false)]
                public string DefaultParameterValue { get; set; }

                /// <summary>
                /// <para>A divisor of the parameter. For a parameter of the integer or byte type, the valid values must be a multiple of Factor unless you set Factor to 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Factor")]
                [Validation(Required=false)]
                public string Factor { get; set; }

                /// <summary>
                /// <para>Indicates whether a cluster restart is required for the parameter modification to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter can be modified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsModifiable")]
                [Validation(Required=false)]
                public bool? IsModifiable { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is a global parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The parameter is a global parameter. The modified parameter value is synchronized to other nodes.</description></item>
                /// <item><description><b>1</b>: The parameter is not a global parameter. You can specify the nodes to which the modified parameter value can be synchronized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsNodeAvailable")]
                [Validation(Required=false)]
                public string IsNodeAvailable { get; set; }

                /// <summary>
                /// <para>The dependencies of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("ParamRelyRule")]
                [Validation(Required=false)]
                public string ParamRelyRule { get; set; }

                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The server\&quot;s default character set.</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>character_set_server</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The status of the parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>Modifying</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("ParameterStatus")]
                [Validation(Required=false)]
                public string ParameterStatus { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
