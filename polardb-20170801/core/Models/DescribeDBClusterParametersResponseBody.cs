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

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyParameters : TeaModel {
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyParametersParameters> Parameters { get; set; }
            public class DescribeDBClusterParametersResponseBodyParametersParameters : TeaModel {
                [NameInMap("IsEqual")]
                [Validation(Required=false)]
                public string IsEqual { get; set; }

                [NameInMap("IsInstancePolarDBKey")]
                [Validation(Required=false)]
                public string IsInstancePolarDBKey { get; set; }

                [NameInMap("IsInstanceRdsKey")]
                [Validation(Required=false)]
                public string IsInstanceRdsKey { get; set; }

                [NameInMap("IsPolarDBKey")]
                [Validation(Required=false)]
                public string IsPolarDBKey { get; set; }

                [NameInMap("IsRdsKey")]
                [Validation(Required=false)]
                public string IsRdsKey { get; set; }

                [NameInMap("distParameterDescription")]
                [Validation(Required=false)]
                public string DistParameterDescription { get; set; }

                [NameInMap("distParameterName")]
                [Validation(Required=false)]
                public string DistParameterName { get; set; }

                [NameInMap("distParameterOptional")]
                [Validation(Required=false)]
                public string DistParameterOptional { get; set; }

                [NameInMap("distParameterValue")]
                [Validation(Required=false)]
                public string DistParameterValue { get; set; }

                [NameInMap("rdsParameterDescription")]
                [Validation(Required=false)]
                public string RdsParameterDescription { get; set; }

                [NameInMap("rdsParameterName")]
                [Validation(Required=false)]
                public string RdsParameterName { get; set; }

                [NameInMap("rdsParameterOptional")]
                [Validation(Required=false)]
                public string RdsParameterOptional { get; set; }

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

        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeDBClusterParametersResponseBodyRunningParametersParameter : TeaModel {
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("DefaultParameterValue")]
                [Validation(Required=false)]
                public string DefaultParameterValue { get; set; }

                [NameInMap("Factor")]
                [Validation(Required=false)]
                public string Factor { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                [NameInMap("IsModifiable")]
                [Validation(Required=false)]
                public bool? IsModifiable { get; set; }

                [NameInMap("IsNodeAvailable")]
                [Validation(Required=false)]
                public string IsNodeAvailable { get; set; }

                [NameInMap("ParamRelyRule")]
                [Validation(Required=false)]
                public string ParamRelyRule { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ParameterStatus")]
                [Validation(Required=false)]
                public string ParameterStatus { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
