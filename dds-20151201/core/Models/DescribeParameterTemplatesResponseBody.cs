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

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeParameterTemplatesResponseBodyParameters Parameters { get; set; }
        public class DescribeParameterTemplatesResponseBodyParameters : TeaModel {
            [NameInMap("TemplateRecord")]
            [Validation(Required=false)]
            public List<DescribeParameterTemplatesResponseBodyParametersTemplateRecord> TemplateRecord { get; set; }
            public class DescribeParameterTemplatesResponseBodyParametersTemplateRecord : TeaModel {
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public bool? ForceModify { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

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
