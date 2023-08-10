// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// The parameters that are used to create the instance.
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class UpdateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The cron expression used to schedule periodic training, in the format of (Minutes Hours DayofMonth Month DayofWeek). The default value is empty, which indicates that no periodic training is performed. DayofWeek 0 indicates Sunday.
        /// </summary>
        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters that are used.
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class UpdateFunctionInstanceRequestUsageParameters : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
