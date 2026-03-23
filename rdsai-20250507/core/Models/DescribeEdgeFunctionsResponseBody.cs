// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeEdgeFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of edge functions.</para>
        /// </summary>
        [NameInMap("EdgeFunctions")]
        [Validation(Required=false)]
        public List<DescribeEdgeFunctionsResponseBodyEdgeFunctions> EdgeFunctions { get; set; }
        public class DescribeEdgeFunctionsResponseBodyEdgeFunctions : TeaModel {
            /// <summary>
            /// <para>The number of vCPUs used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The time when the function was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-12T21:35:03</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The edge function name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ef-****</para>
            /// </summary>
            [NameInMap("EdgeFunctionName")]
            [Validation(Required=false)]
            public string EdgeFunctionName { get; set; }

            /// <summary>
            /// <para>The URL for accessing the function.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://fcnext.console.aliyun.com/cn-beijing/functions/fc">https://fcnext.console.aliyun.com/cn-beijing/functions/fc</a>****</para>
            /// </summary>
            [NameInMap("FunctionUrl")]
            [Validation(Required=false)]
            public string FunctionUrl { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The time when the function was last created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-25 10:22:54 +0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The runtime environment for the function, which includes the Linux environment and the Deno version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom.debian12-deno-2.5.6</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/2623972.html">Instance state table</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The public URL for accessing the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://fc-bfvmoi****.cn-beijing.fcapp.run">https://fc-bfvmoi****.cn-beijing.fcapp.run</a></para>
            /// </summary>
            [NameInMap("UrlInternet")]
            [Validation(Required=false)]
            public string UrlInternet { get; set; }

            /// <summary>
            /// <para>The internal URL for accessing the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://fc-bfvmoi****.cn-beijing-vpc.fcapp.run">https://fc-bfvmoi****.cn-beijing-vpc.fcapp.run</a></para>
            /// </summary>
            [NameInMap("UrlIntranet")]
            [Validation(Required=false)]
            public string UrlIntranet { get; set; }

        }

        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
