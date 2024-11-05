// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter settings in the configuration template.</para>
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
                /// <para>The valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0-65536]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart is required for parameter modifications to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: A restart is not required. Modifications take effect immediately.</description></item>
                /// <item><description><b>true</b>: A restart is required for parameter modifications to take effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter value can be modified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: The parameter value cannot be modified.</description></item>
                /// <item><description><b>true</b>: The parameter value can be modified.</description></item>
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
                /// <para>The threshold in milliseconds at which the database profiler considers a query slow, default is 100.</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>operationProfiling.slowOpThresholdMs</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The database engine of the instance. Default value: <b>mongodb</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mongodb</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ADD0C7D-2D2A-4F15-88FF-E7AC9B9FDCC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The settings of the parameters that have taken effect.</para>
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
                /// <para>实例的角色类型，取值说明：</para>
                /// <list type="bullet">
                /// <item><description><b>db</b>：shard角色。</description></item>
                /// <item><description><b>cs</b>：config server角色。</description></item>
                /// <item><description><b>mongos</b>：mongos角色。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                /// <summary>
                /// <para>The valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[33554432-268435456]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart is required for parameter modifications to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: A restart is not required. Modifications take effect immediately.</description></item>
                /// <item><description><b>true</b>: A restart is required for parameter modifications to take effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public string ForceRestart { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter value can be modified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: The parameter value cannot be modified.</description></item>
                /// <item><description><b>true</b>: The parameter value can be modified.</description></item>
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
                /// <para>The maximum memory bytes that sort stage may use, default is 33554432(i.e. 32MB)</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>setParameter.internalQueryExecMaxBlockingSortBytes</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33554432</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
