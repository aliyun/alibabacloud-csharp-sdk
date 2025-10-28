// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListScaleOutEcuRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Specify this parameter if you want to query the available ECUs in the cluster where the application is deployed.</para>
        /// <remarks>
        /// <para> Specify at least one of the ClusterId and AppId parameters as the query parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b93024fd-8a9d-4ef7-99f1-5f0d65cc****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. Specify this parameter if you want to query the available ECUs in the cluster.</para>
        /// <remarks>
        /// <para>Specify at least one of the ClusterId and AppId parameters as the query parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>52984524-6d48-4bbd-******************</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of CPU cores based on which you want to query the available ECUs in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The ID of the instance group. Specify this parameter if you want to query the available ECUs in the cluster where the instance group resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-486f-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of ECUs that you want to query. If this parameter is not specified, all the ECUs that meet the query conditions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceNum")]
        [Validation(Required=false)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a custom namespace is in the <c>region ID:namespace identifier</c> format. Example: cn-beijing:test.</description></item>
        /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: cn-beijing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The size of available memory based on which you want to query the available ECUs in the cluster. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public int? Mem { get; set; }

    }

}
