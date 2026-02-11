// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeUserModelListResponseBody : TeaModel {
        /// <summary>
        /// <para><c>code</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Pagination parameter: number of items per page, default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A91D2D1-AEC9-1658-ABCE-5A39DE66A5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<DescribeUserModelListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeUserModelListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READ</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Model_A</para>
            /// </summary>
            [NameInMap("CustomerModuleName")]
            [Validation(Required=false)]
            public string CustomerModuleName { get; set; }

            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Associated features.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_a</para>
            /// </summary>
            [NameInMap("FeatureTemplate")]
            [Validation(Required=false)]
            public string FeatureTemplate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673578656000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Primary key ID of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Publication status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("InnerDefineStatus")]
            [Validation(Required=false)]
            public string InnerDefineStatus { get; set; }

            /// <summary>
            /// <para>Model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inner_model_a</para>
            /// </summary>
            [NameInMap("InnerModuleName")]
            [Validation(Required=false)]
            public string InnerModuleName { get; set; }

            /// <summary>
            /// <para>Whether iteration is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAllowIterate")]
            [Validation(Required=false)]
            public bool? IsAllowIterate { get; set; }

            /// <summary>
            /// <para>Whether rollback is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAllowRollback")]
            [Validation(Required=false)]
            public bool? IsAllowRollback { get; set; }

            /// <summary>
            /// <para>Iteration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IterationVersion")]
            [Validation(Required=false)]
            public long? IterationVersion { get; set; }

            /// <summary>
            /// <para>Root model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RootModuleId")]
            [Validation(Required=false)]
            public long? RootModuleId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description>true, request succeeded</description></item>
        /// <item><description>false, request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public long? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
