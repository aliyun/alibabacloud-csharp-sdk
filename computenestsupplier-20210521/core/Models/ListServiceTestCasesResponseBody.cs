// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceTestCasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceTestCasesResponseBodyData> Data { get; set; }
        public class ListServiceTestCasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The service test case id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stc-83fcee1383354e35b151</para>
            /// </summary>
            [NameInMap("TestCaseId")]
            [Validation(Required=false)]
            public string TestCaseId { get; set; }

            /// <summary>
            /// <para>The service test case name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>case1</para>
            /// </summary>
            [NameInMap("TestCaseName")]
            [Validation(Required=false)]
            public string TestCaseName { get; set; }

            /// <summary>
            /// <para>The service test config.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// <para>parameters:
            ///   PayType: &quot;PostPaid&quot;
            ///   EcsInstanceType: &quot;$[iact3-auto]&quot;
            ///   InstancePassword: &quot;$[iact3-auto]&quot;</para>
            /// </summary>
            [NameInMap("TestConfig")]
            [Validation(Required=false)]
            public string TestConfig { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA3AE512-6D30-549A-B52D-B9042CA8D515</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
