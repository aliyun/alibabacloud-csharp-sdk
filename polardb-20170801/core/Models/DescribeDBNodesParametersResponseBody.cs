// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBNodesParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the nodes.</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public List<DescribeDBNodesParametersResponseBodyDBNodeIds> DBNodeIds { get; set; }
        public class DescribeDBNodesParametersResponseBodyDBNodeIds : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp1r4qe3s534*****</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The parameters of the current node.</para>
            /// </summary>
            [NameInMap("RunningParameters")]
            [Validation(Required=false)]
            public List<DescribeDBNodesParametersResponseBodyDBNodeIdsRunningParameters> RunningParameters { get; set; }
            public class DescribeDBNodesParametersResponseBodyDBNodeIdsRunningParameters : TeaModel {
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
                /// <para>Indicates whether a cluster restart is required to allow the parameter modification to take effect. Valid values:</para>
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
                /// <item><description><b>0</b>: yes. The modified parameter value is synchronized to other nodes.</description></item>
                /// <item><description><b>1</b>: no. You can customize the nodes to which the modified parameter value can be synchronized to.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>modifying</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
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

        /// <summary>
        /// <para>The type of the database engine. Set the value to <b>MySQL</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the MySQL database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
