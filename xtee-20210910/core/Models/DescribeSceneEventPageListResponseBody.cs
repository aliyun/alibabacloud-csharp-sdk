// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneEventPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Number of items per page. Default value: 20, minimum value: 1, maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID, each request has a unique value, which facilitates subsequent troubleshooting</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return array</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneEventPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneEventPageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Number of common rules</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("commonRuleCount")]
            [Validation(Required=false)]
            public string CommonRuleCount { get; set; }

            /// <summary>
            /// <para>Number of custom rules</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("customRuleCount")]
            [Validation(Required=false)]
            public string CustomRuleCount { get; set; }

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
            /// <para>Modification time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Modifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>公有云用户uid</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>Number of custom rules</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("normalRuleCount")]
            [Validation(Required=false)]
            public string NormalRuleCount { get; set; }

            /// <summary>
            /// <para>Service code</para>
            /// 
            /// <b>Example:</b>
            /// <para>device_risk</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>Usage status</para>
            /// 
            /// <b>Example:</b>
            /// <para>使用/未使用</para>
            /// </summary>
            [NameInMap("useStatus")]
            [Validation(Required=false)]
            public string UseStatus { get; set; }

            /// <summary>
            /// <para>Number of white-box rules</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("whiteBoxRuleCount")]
            [Validation(Required=false)]
            public string WhiteBoxRuleCount { get; set; }

        }

        /// <summary>
        /// <para>Total number of items</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
