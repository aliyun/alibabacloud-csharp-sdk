// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeSandboxTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that indicates the position from which the current read operation starts. An empty value indicates that the read operation starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLYz/NvD85HpgBeRBCusEIeVQ0dHZH9jr+NP3X9Jx0iSoql55b9nd4PIDm252/a0f+U=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of sandbox templates.</para>
        /// </summary>
        [NameInMap("SandboxTemplates")]
        [Validation(Required=false)]
        public List<DescribeSandboxTemplatesResponseBodySandboxTemplates> SandboxTemplates { get; set; }
        public class DescribeSandboxTemplatesResponseBodySandboxTemplates : TeaModel {
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The number of CPUs for the sandbox created with this template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DefaultCpu")]
            [Validation(Required=false)]
            public string DefaultCpu { get; set; }

            /// <summary>
            /// <para>The memory size of the sandbox created with this template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4Gi</para>
            /// </summary>
            [NameInMap("DefaultMemory")]
            [Validation(Required=false)]
            public string DefaultMemory { get; set; }

            /// <summary>
            /// <para>The sandbox template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-interpreter-vpc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the sandbox created with this template can access resources in the VPC where Supabase resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVpcAccess")]
            [Validation(Required=false)]
            public string EnableVpcAccess { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The sandbox template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-interpreter</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public long? Replicas { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>The sandbox template ID. Specify this ID when creating a sandbox with this template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-interpreter-asdxxxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The total number of records that match the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
