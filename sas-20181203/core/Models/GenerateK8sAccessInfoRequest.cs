// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateK8sAccessInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayApiName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayApiName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayPopName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayPopName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayProjectName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayProjectName { get; set; }

        /// <summary>
        /// <para>The SLS Logstore of the audit log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit-cf6baf6afa106eca665296fdf68b65bf</para>
        /// </summary>
        [NameInMap("AuditLogStore")]
        [Validation(Required=false)]
        public string AuditLogStore { get; set; }

        /// <summary>
        /// <para>The SLS project of the audit log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-custom-huxintest1018-2</para>
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// <para>The region of the audit log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AuditRegionId")]
        [Validation(Required=false)]
        public string AuditRegionId { get; set; }

        /// <summary>
        /// <para>The name of the Kubernetes cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The CPU architecture, which can be ARM or x86.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arm</para>
        /// </summary>
        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        /// <summary>
        /// <para>The expiration time for container access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711951508388</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// <para>The queried group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11341690</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The cloud asset vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b></description></item>
        /// <item><description><b>HUAWEICLOUD</b></description></item>
        /// <item><description><b>Azure</b></description></item>
        /// <item><description><b>AWS</b> </description></item>
        /// <item><description><b>Other cloud assets</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
