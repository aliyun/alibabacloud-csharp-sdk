// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Sentieon</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        [NameInMap("BillingInstanceIds")]
        [Validation(Required=false)]
        public List<string> BillingInstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Calls")]
        [Validation(Required=false)]
        public string Calls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-10T13:30:20.414557061Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("DefaultRuntime")]
        [Validation(Required=false)]
        public string DefaultRuntime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test run</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-10T13:36:20.405878292Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s1</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/exec/</para>
        /// </summary>
        [NameInMap("ExecuteDirectory")]
        [Validation(Required=false)]
        public string ExecuteDirectory { get; set; }

        [NameInMap("ExecuteOptions")]
        [Validation(Required=false)]
        public GetRunResponseBodyExecuteOptions ExecuteOptions { get; set; }
        public class GetRunResponseBodyExecuteOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CallCaching")]
            [Validation(Required=false)]
            public bool? CallCaching { get; set; }

            [NameInMap("DataLoader")]
            [Validation(Required=false)]
            public string DataLoader { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeleteIntermediateResults")]
            [Validation(Required=false)]
            public bool? DeleteIntermediateResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NoNewCalls</para>
            /// </summary>
            [NameInMap("FailureMode")]
            [Validation(Required=false)]
            public string FailureMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseRelativeOutputPaths")]
            [Validation(Required=false)]
            public bool? UseRelativeOutputPaths { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public string Failures { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;workflow1.task1.param1&quot;: &quot;helloooo.txt&quot;,     &quot;workflow1.task1.param2&quot;: &quot;abc&quot;,     &quot;workflow1.task2.param1&quot;: &quot;new_helloooo.txt&quot;,     &quot;workflow1.task2.param2&quot;: &quot;def&quot; }</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/output/</para>
        /// </summary>
        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{         &quot;workflow1.bam&quot;: &quot;oss://my-bucket/test.bam&quot;,         &quot;workflow1.vcf&quot;: &quot;oss://my-bucket/test.vcf&quot;     }</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>run-13BeYuxc0fxO24uA75UppTiMRoQ</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-run</para>
        /// </summary>
        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EasyGene</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-10T13:30:24.414557061Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sub-13BeXWnGvrOl3MC124tazcJVKaV</para>
        /// </summary>
        [NameInMap("SubmissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Timing")]
        [Validation(Required=false)]
        public string Timing { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13579222</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
