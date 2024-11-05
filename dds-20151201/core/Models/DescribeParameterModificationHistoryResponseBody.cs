// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParameterModificationHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the parameter modification records.</para>
        /// </summary>
        [NameInMap("HistoricalParameters")]
        [Validation(Required=false)]
        public DescribeParameterModificationHistoryResponseBodyHistoricalParameters HistoricalParameters { get; set; }
        public class DescribeParameterModificationHistoryResponseBodyHistoricalParameters : TeaModel {
            [NameInMap("HistoricalParameter")]
            [Validation(Required=false)]
            public List<DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter> HistoricalParameter { get; set; }
            public class DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter : TeaModel {
                /// <summary>
                /// <para>The time when the parameter was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-12T07:58:24Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The parameter value after modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("NewParameterValue")]
                [Validation(Required=false)]
                public string NewParameterValue { get; set; }

                /// <summary>
                /// <para>The parameter value before modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OldParameterValue")]
                [Validation(Required=false)]
                public string OldParameterValue { get; set; }

                /// <summary>
                /// <para>The name of the modified parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>operationProfiling.slowOpThresholdMs</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1BB6E0E-B4EF-4145-81FA-A07719860248</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
