// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterModificationHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the parameter modification records.</para>
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
                /// <para>The time when the parameter was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-05T09:56:10Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The parameter value after modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NewParameterValue")]
                [Validation(Required=false)]
                public string NewParameterValue { get; set; }

                /// <summary>
                /// <para>The parameter value before modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-2</para>
                /// </summary>
                [NameInMap("OldParameterValue")]
                [Validation(Required=false)]
                public string OldParameterValue { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>script_check_enable</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>963C20F0-7CE1-4591-AAF3-6F3CD1CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
