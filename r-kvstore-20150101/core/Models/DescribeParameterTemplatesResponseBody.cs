// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The database engine that is run on the instance. The value **Redis** is returned for this parameter.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The major version that is run on the instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The number of parameters that are supported by the instance.
        /// </summary>
        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        /// <summary>
        /// An array that consists of the details about the parameters returned.
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
                /// The valid values of the parameter.
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// Indicates whether the parameter can be reconfigured. Valid values:
                /// 
                /// *   **true**: The parameter can be reconfigured.
                /// *   **false**: The parameter cannot be reconfigured.
                /// </summary>
                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public bool? ForceModify { get; set; }

                /// <summary>
                /// Indicates whether a restart of the instance is required after the parameter is reconfigured. Valid values:
                /// 
                /// *   **true**: After the parameter is reconfigured, you must restart the instance to make the new value of the parameter take effect.
                /// *   **false**: After the parameter is reconfigured, the new value of the parameter immediately takes effect. You do not need to restart the instance.
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// The name of the parameter. For more information about the parameters and the parameter settings, see [Parameters](~~259681~~).
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The default value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
