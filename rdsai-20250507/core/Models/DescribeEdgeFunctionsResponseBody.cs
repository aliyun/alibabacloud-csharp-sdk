// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeEdgeFunctionsResponseBody : TeaModel {
        [NameInMap("EdgeFunctions")]
        [Validation(Required=false)]
        public List<DescribeEdgeFunctionsResponseBodyEdgeFunctions> EdgeFunctions { get; set; }
        public class DescribeEdgeFunctionsResponseBodyEdgeFunctions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-12T21:35:03</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ef-****</para>
            /// </summary>
            [NameInMap("EdgeFunctionName")]
            [Validation(Required=false)]
            public string EdgeFunctionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://fcnext.console.aliyun.com/cn-beijing/functions/fc">https://fcnext.console.aliyun.com/cn-beijing/functions/fc</a>****</para>
            /// </summary>
            [NameInMap("FunctionUrl")]
            [Validation(Required=false)]
            public string FunctionUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-25 10:22:54 +0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom.debian12-deno-2.5.6</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://fc-bfvmoi****.cn-beijing.fcapp.run">https://fc-bfvmoi****.cn-beijing.fcapp.run</a></para>
            /// </summary>
            [NameInMap("UrlInternet")]
            [Validation(Required=false)]
            public string UrlInternet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://fc-bfvmoi****.cn-beijing-vpc.fcapp.run">https://fc-bfvmoi****.cn-beijing-vpc.fcapp.run</a></para>
            /// </summary>
            [NameInMap("UrlIntranet")]
            [Validation(Required=false)]
            public string UrlIntranet { get; set; }

        }

        /// <summary>
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
