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
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

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
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

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

}
