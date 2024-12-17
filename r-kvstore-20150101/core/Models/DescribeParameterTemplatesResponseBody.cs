// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine that is run on the instance. The value <b>Redis</b> is returned for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The major version that is run on the instance.</para>
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
        /// <para>24</para>
        /// </summary>
        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        /// <summary>
        /// <para>An array that consists of the details about the parameters returned.</para>
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
                /// <para>The valid values of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[yes|no]</para>
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter can be reconfigured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The parameter can be reconfigured.</description></item>
                /// <item><description><b>false</b>: The parameter cannot be reconfigured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public bool? ForceModify { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart of the instance is required after the parameter is reconfigured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: After the parameter is reconfigured, you must restart the instance to make the new value of the parameter take effect.</description></item>
                /// <item><description><b>false</b>: After the parameter is reconfigured, the new value of the parameter immediately takes effect. You do not need to restart the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test description</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The name of the parameter. For more information about the parameters and the parameter settings, see <a href="https://help.aliyun.com/document_detail/259681.html">Parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appendonly</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yes</para>
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
        /// <para>9DA28D8E-514D-4F12-ADED-70A9C818****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
