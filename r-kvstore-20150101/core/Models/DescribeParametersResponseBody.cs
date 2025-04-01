// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration parameters that have not taken effect.</para>
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyConfigParameters ConfigParameters { get; set; }
        public class DescribeParametersResponseBodyConfigParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyConfigParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyConfigParametersParameter : TeaModel {
                /// <summary>
                /// <para>The check code that indicates the valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0|1]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance must be restarted for the modifications to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>True</b>: The instance must be restarted for the modifications to take effect.</description></item>
                /// <item><description><b>False</b>: The instance does not need to be restarted for the modifications to take effect. Modifications immediately take effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter can be reset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>False</b>: The parameter cannot be reset.</description></item>
                /// <item><description><b>True</b>: The parameter can be reset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public bool? ModifiableStatus { get; set; }

                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Check all keys passed in the KEYS array map to the same slot.</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>script_check_enable</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The database engine that the instance runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C1338BE-8DE8-4890-A900-E1BC06BF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The running parameters.</para>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyRunningParametersParameter : TeaModel {
                /// <summary>
                /// <para>The check code that indicates the valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0|1]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance must be restarted for the modifications to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>True</b>: The instance must be restarted for the modifications to take effect.</description></item>
                /// <item><description><b>False</b>: The instance does not need to be restarted for the modifications to take effect. Modifications immediately take effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public string ForceRestart { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter can be reset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>False</b>: The parameter cannot be reset.</description></item>
                /// <item><description><b>True</b>: The parameter can be reset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public string ModifiableStatus { get; set; }

                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You can disable some dangerous commands, for example \&quot;keys,flushdb,flushall\&quot;, the commands must be in [flushall,flushdb,keys,hgetall,eval,evalsha,script].</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#no_loose_disabled-commands</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>keys,flushall,flushdb</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
