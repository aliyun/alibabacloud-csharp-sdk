// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupDrdsParamsRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SetupDrdsParamsRequestData> Data { get; set; }
        public class SetupDrdsParamsRequestData : TeaModel {
            /// <summary>
            /// The name of the parameter that you want to configure for a database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The valid values of the parameter.
            /// </summary>
            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            /// <summary>
            /// The type of the parameter that you want to configure. Valid values:
            /// 
            /// *   **ATOM**: the configuration item in the layer-3 data source.
            /// *   **CONFIG**: the configuration item in ConfigServer.
            /// *   **DIAMOND**: the configuration item in Diamond.
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// The value of parameter that you want to configure.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            /// <summary>
            /// The name of the parameter that you want to configure.
            /// </summary>
            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance for which you want to configure parameters.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The resource for which you want to configure parameters. Valid values:
        /// 
        /// *   **INSTANCE**: Configure parameters for the instance.
        /// *   **DB**: Configure parameters for the databases of the instance.
        /// </summary>
        [NameInMap("ParamLevel")]
        [Validation(Required=false)]
        public string ParamLevel { get; set; }

        /// <summary>
        /// The ID of the region in which the PolarDB-X 1.0 instance is located.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
