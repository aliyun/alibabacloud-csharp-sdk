// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceParametersResponseBody : TeaModel {
        /// <summary>
        /// The range of ParameterValue.
        /// 
        /// > The value of CheckingCode varies based on the value of ParameterName.
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyConfigParameters> ConfigParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyConfigParameters : TeaModel {
            /// <summary>
            /// The check code that indicates the valid values of the parameter.
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// Does it support modifying parameter values. Possible values:
            /// 
            /// - true:Support modifying parameter values.
            /// 
            /// - false:Modifying parameter values is not supported.
            /// </summary>
            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            /// <summary>
            /// Specifies whether to forcibly restart the instance after parameters are modified. Valid values:
            /// 
            /// *   true: forcibly restarts the instance. If a new parameter value takes effect only after the instance restarts, you must set this parameter to true. Otherwise, the new parameter value cannot take effect.
            /// *   false: does not forcibly restart the instance.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// The description of the parameter.
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The database engine that the instance runs. The value must be MySQL.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// *   5.7: MySQL 5.7.
        /// *   8.0: MySQL 8.0.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The range of ParameterValue.
        /// 
        /// > The value of CheckingCode varies based on the value of ParameterName.
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyRunningParameters> RunningParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyRunningParameters : TeaModel {
            /// <summary>
            /// The check code that indicates the valid values of the parameter.
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// Does it support modifying parameter values. Possible values:
            /// 
            /// - true:Support modifying parameter values.
            /// 
            /// - false:Modifying parameter values is not supported.
            /// </summary>
            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            /// <summary>
            /// Specifies whether to forcibly restart the instance after parameters are modified. Valid values:
            /// 
            /// *   true: forcibly restarts the instance. If a new parameter value takes effect only after the instance restarts, you must set this parameter to true. Otherwise, the new parameter value cannot take effect.
            /// *   false: does not forcibly restart the instance.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// The description of the parameter.
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

    }

}
