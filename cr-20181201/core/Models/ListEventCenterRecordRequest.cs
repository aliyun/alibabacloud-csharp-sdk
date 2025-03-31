// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListEventCenterRecordRequest : TeaModel {
        /// <summary>
        /// <para>The type of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cr:Artifact:DeliveryChainCompleted</c>: The delivery chain is processed.</description></item>
        /// <item><description><c>cr:Artifact:SynchronizationCompleted</c>: The image is replicated.</description></item>
        /// <item><description><c>cr:Artifact:BuildCompleted</c>: The image is built.</description></item>
        /// <item><description><c>cr:Artifact:ScanCompleted</c>: The image is scanned.</description></item>
        /// <item><description><c>cr:Artifact:SigningCompleted</c>: The image is signed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cr:Artifact:DeliveryChainCompleted</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The name of the namespace to which the repository belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The ID of the event notification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crecr-n6pbhgjxtla***</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
