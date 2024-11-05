// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine of the instance.</para>
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
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The number of parameters that are supported by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        /// <summary>
        /// <para>Details about the parameter templates.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeParameterTemplatesResponseBodyParameters Parameters { get; set; }
        public class DescribeParameterTemplatesResponseBodyParameters : TeaModel {
            [NameInMap("TemplateRecord")]
            [Validation(Required=false)]
            public List<DescribeParameterTemplatesResponseBodyParametersTemplateRecord> TemplateRecord { get; set; }
            public class DescribeParameterTemplatesResponseBodyParametersTemplateRecord : TeaModel {
                /// <summary>
                /// <para>The value range of modifiable parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0-65536]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is modifiable.</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: The parameter cannot be modified.</description></item>
                /// <item><description><b>true</b>: The parameter can be modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public bool? ForceModify { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart is required for parameter modifications to take effect.</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: A restart is not required. Parameter modifications immediately take effect.</description></item>
                /// <item><description><b>true</b>: A restart is required for parameter modifications to take effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

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
                /// <para>net.compression.compressors</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDA54203-9D61-54A3-A568-D281F785****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
