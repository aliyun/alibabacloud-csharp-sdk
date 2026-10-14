// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebInstanceRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0222382B-5FE5-4FF7-BC9B-97EE31D58818</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about Anti-DDoS Pro or Anti-DDoS Premium instances associated with website services.</para>
        /// </summary>
        [NameInMap("WebInstanceRelations")]
        [Validation(Required=false)]
        public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelations> WebInstanceRelations { get; set; }
        public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelations : TeaModel {
            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The information about the associated Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
            /// </summary>
            [NameInMap("InstanceDetails")]
            [Validation(Required=false)]
            public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails : TeaModel {
                /// <summary>
                /// <para>The list of IP addresses of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
                /// </summary>
                [NameInMap("EipList")]
                [Validation(Required=false)]
                public List<string> EipList { get; set; }

                /// <summary>
                /// <para>The function plan type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>default</b>: Standard function.</description></item>
                /// <item><description><b>enhance</b>: Enhanced function.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enhance</para>
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// <para>The Anti-DDoS Pro or Anti-DDoS Premium instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddoscoo-cn-0pp163pd****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
