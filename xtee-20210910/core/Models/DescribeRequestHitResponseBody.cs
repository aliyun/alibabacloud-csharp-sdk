// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRequestHitResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRequestHitResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRequestHitResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Event code</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>Event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险</para>
            /// </summary>
            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>Input parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;eventCode\&quot;:\&quot;de_afghcf6411\&quot;,\&quot;ip\&quot;:\&quot;196.168.0.1\&quot;,\&quot;DEtest222\&quot;:9007199254740999,\&quot;age\&quot;:20}</para>
            /// </summary>
            [NameInMap("inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            /// <summary>
            /// <para>Output parameters</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;tags\&quot;:\&quot;rm0102,test_tag,age\&quot;,\&quot;score\&quot;:\&quot;30.0\&quot;,\&quot;extend\&quot;:\&quot;{\\\&quot;OUT_V01\\\&quot;:\\\&quot;Maritime\\\&quot;,\\\&quot;OUT_V02\\\&quot;:\\\&quot;Lome\\\&quot;,\\\&quot;OUT_V03\\\&quot;:\\\&quot;196.168.0.1_A\\\&quot;}\&quot;,\&quot;finalDecision\&quot;:\&quot;REJECT\&quot;}</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>Timestamp of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752571330000</para>
            /// </summary>
            [NameInMap("requestTime")]
            [Validation(Required=false)]
            public long? RequestTime { get; set; }

            /// <summary>
            /// <para>Details of the executed rules.</para>
            /// </summary>
            [NameInMap("ruleHitRecords")]
            [Validation(Required=false)]
            public List<DescribeRequestHitResponseBodyResultObjectRuleHitRecords> RuleHitRecords { get; set; }
            public class DescribeRequestHitResponseBodyResultObjectRuleHitRecords : TeaModel {
                /// <summary>
                /// <para>Duration</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cost")]
                [Validation(Required=false)]
                public int? Cost { get; set; }

                /// <summary>
                /// <para>Whether the rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hitSuccessful")]
                [Validation(Required=false)]
                public bool? HitSuccessful { get; set; }

                /// <summary>
                /// <para>Whether to show details</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isShowDetail")]
                [Validation(Required=false)]
                public bool? IsShowDetail { get; set; }

                /// <summary>
                /// <para>Order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>Policy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>101544</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>Policy name</para>
                /// 
                /// <b>Example:</b>
                /// <para>注册手机号是11位数字</para>
                /// </summary>
                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Rule snapshot ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("ruleSnapshotId")]
                [Validation(Required=false)]
                public string RuleSnapshotId { get; set; }

                /// <summary>
                /// <para>Policy status</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

            }

            /// <summary>
            /// <para>Request ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>60C97040-D5D5-4906-9522-B9B413730CAA</para>
            /// </summary>
            [NameInMap("sRequestId")]
            [Validation(Required=false)]
            public string SRequestId { get; set; }

            /// <summary>
            /// <para>Total amount of the request</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCost")]
            [Validation(Required=false)]
            public long? TotalCost { get; set; }

        }

    }

}
