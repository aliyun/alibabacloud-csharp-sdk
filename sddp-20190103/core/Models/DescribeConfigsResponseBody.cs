// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of common configuration items for alerts.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeConfigsResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeConfigsResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The code of the common configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The description of the default value for the common configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The volume of logs of a specific type that are generated on the current day is less than 30% of the average volume of logs generated in the previous 10 days.</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The description of the common configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anomalous log output</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the common configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2133</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The value of the common configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
