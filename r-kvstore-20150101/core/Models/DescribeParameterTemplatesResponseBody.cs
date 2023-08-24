// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The valid values of the parameter.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The default value of the parameter.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The architecture of the instance. For more information, see [Overview](~~86132~~). Valid values:
        /// 
        /// *   **logic**: The instance is a cluster master-replica instance or a read/write splitting instance.
        /// *   **normal**: The instance is a standard master-replica instance.
        /// </summary>
        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        /// <summary>
        /// Redis
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
                /// The number of parameters that are supported by the instance.
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// DescribeParameterTemplates
                /// </summary>
                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public bool? ForceModify { get; set; }

                /// <summary>
                /// Queries the parameters and default values of an ApsaraDB for Redis instance that runs a specific major version in a specific architecture.
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// 5.0
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs. You can call the [ListResourceGroups](~~158855~~) operation to query the IDs of resource groups.
                /// 
                /// >  You can also query the ID of a resource group in the Resource Management console. For more information, see [View the basic information of a resource group](~~151181~~).
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// The name of the parameter. For more information about the parameters and the parameter settings, see [Parameters](~~259681~~).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
