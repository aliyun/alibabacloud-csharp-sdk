// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota of Chart namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChartNamespaceQuota")]
        [Validation(Required=false)]
        public string ChartNamespaceQuota { get; set; }

        /// <summary>
        /// <para>The number of Chart namespaces created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChartNamespaceUsage")]
        [Validation(Required=false)]
        public string ChartNamespaceUsage { get; set; }

        /// <summary>
        /// <para>The quota of Chart repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("ChartRepoQuota")]
        [Validation(Required=false)]
        public string ChartRepoQuota { get; set; }

        /// <summary>
        /// <para>The number of Chart repositories created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ChartRepoUsage")]
        [Validation(Required=false)]
        public string ChartRepoUsage { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The quota of image namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public string NamespaceQuota { get; set; }

        /// <summary>
        /// <para>The number of image namespaces used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NamespaceUsage")]
        [Validation(Required=false)]
        public string NamespaceUsage { get; set; }

        /// <summary>
        /// <para>The number of performance units, which indicates the additional instance capacity purchased on top of the Advanced Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PerformanceUnits")]
        [Validation(Required=false)]
        public int? PerformanceUnits { get; set; }

        /// <summary>
        /// <para>The quota of image repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RepoQuota")]
        [Validation(Required=false)]
        public string RepoQuota { get; set; }

        /// <summary>
        /// <para>The number of image repositories used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RepoUsage")]
        [Validation(Required=false)]
        public string RepoUsage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A726E801-7FCF-43F9-AF1C-51B3E65D3E7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The VPC quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("VpcQuota")]
        [Validation(Required=false)]
        public string VpcQuota { get; set; }

        /// <summary>
        /// <para>The number of bound VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("VpcUsage")]
        [Validation(Required=false)]
        public string VpcUsage { get; set; }

    }

}
