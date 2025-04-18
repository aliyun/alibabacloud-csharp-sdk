// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateAndAnalyzeNetworkPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the task for analyzing network reachability that you initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nra-dfe9e53d2b524568****</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisId")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisId { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the source resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf62y8khhbkbdrp6****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// <para>The source port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public string SourcePort { get; set; }

        /// <summary>
        /// <para>The type of the source resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the destination resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-m5eactvw7wtpktv5****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.50.XX.XX</para>
        /// </summary>
        [NameInMap("TargetIpAddress")]
        [Validation(Required=false)]
        public string TargetIpAddress { get; set; }

        /// <summary>
        /// <para>The destination port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The type of the destination resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
