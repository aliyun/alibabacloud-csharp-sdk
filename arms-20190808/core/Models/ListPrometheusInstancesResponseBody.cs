// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The Prometheus instances in the region in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;agentStatus&quot;:&quot;0&quot;,&quot;clusterId&quot;:&quot;global-v2-cn-1672753017899-dmjnwtzz&quot;,&quot;clusterName&quot;:&quot;test-GlobalView&quot;,&quot;clusterType&quot;:&quot;GlobalViewV2&quot;,&quot;commercialConfig&quot;:{},&quot;createTime&quot;:1656579981000,&quot;id&quot;:13785300,&quot;isAdvancedClusterInstalled&quot;:false,&quot;isClusterRunning&quot;:true,&quot;isControllerInstalled&quot;:true,&quot;isIntegrationCenter&quot;:false,&quot;regionId&quot;:&quot;cn-hongkong&quot;,&quot;updateTime&quot;:1657616273000,&quot;userId&quot;:&quot;1672753017899&quot;},{&quot;agentStatus&quot;:&quot;0&quot;,&quot;clusterId&quot;:&quot;51a123a61a8f31f0&quot;,&quot;clusterName&quot;:&quot;cloud-product-prometheus_cn-qingdao&quot;,&quot;clusterType&quot;:&quot;cloud-product-prometheus&quot;,&quot;commercialConfig&quot;:{},&quot;controllerId&quot;:&quot;51a123a61a8f31f0&quot;,&quot;createTime&quot;:1653532488000,&quot;id&quot;:13746658,&quot;isAdvancedClusterInstalled&quot;:false,&quot;isClusterRunning&quot;:true,&quot;isControllerInstalled&quot;:true,&quot;isIntegrationCenter&quot;:false,&quot;regionId&quot;:&quot;cn-qingdao&quot;,&quot;updateTime&quot;:1653532518000,&quot;userId&quot;:&quot;1672753017899&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9C9DA3D-10FE-472E-9EEF-2D0A3E41****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
