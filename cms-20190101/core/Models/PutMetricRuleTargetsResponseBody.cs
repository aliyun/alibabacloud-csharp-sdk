// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The failed data.</para>
        /// </summary>
        [NameInMap("FailData")]
        [Validation(Required=false)]
        public PutMetricRuleTargetsResponseBodyFailData FailData { get; set; }
        public class PutMetricRuleTargetsResponseBodyFailData : TeaModel {
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public PutMetricRuleTargetsResponseBodyFailDataTargets Targets { get; set; }
            public class PutMetricRuleTargetsResponseBodyFailDataTargets : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public List<PutMetricRuleTargetsResponseBodyFailDataTargetsTarget> Target { get; set; }
                public class PutMetricRuleTargetsResponseBodyFailDataTargetsTarget : TeaModel {
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A569B0D-9055-58AF-9E82-BAEAF95C0FD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
