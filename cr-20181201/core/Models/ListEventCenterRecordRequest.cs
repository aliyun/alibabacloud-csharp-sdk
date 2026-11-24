// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListEventCenterRecordRequest : TeaModel {
        /// <summary>
        /// <para>The event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cr:Artifact:DeliveryChainCompleted</c>: Delivery chain processing completed.</description></item>
        /// <item><description><c>cr:Artifact:SynchronizationCompleted</c>: Image synchronization completed.</description></item>
        /// <item><description><c>cr:Artifact:BuildCompleted</c>: Image building completed.</description></item>
        /// <item><description><c>cr:Artifact:ScanCompleted</c>: Image scanning completed.</description></item>
        /// <item><description><c>cr:Artifact:SigningCompleted</c>: Image signing completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cr:Artifact:DeliveryChainCompleted</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The repository namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The event rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crecr-n6pbhgjxtla***</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
