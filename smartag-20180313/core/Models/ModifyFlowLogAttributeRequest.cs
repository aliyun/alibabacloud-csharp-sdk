// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyFlowLogAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The interval at which log data of active network connections is collected. Default value: <b>300</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ActiveAging")]
        [Validation(Required=false)]
        public int? ActiveAging { get; set; }

        /// <summary>
        /// <para>The description of the flow log.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the flow log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fl-7a56mar1kfw9vj****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The interval at which log data of inactive network connections is collected. Default value: <b>15</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("InactiveAging")]
        [Validation(Required=false)]
        public int? InactiveAging { get; set; }

        /// <summary>
        /// <para>The Logstore of Log Service. This parameter is required when OutputType is set to <b>sls</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssfghgh</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DDE</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IP address of the NetFlow collector where the flow log is stored. This parameter is required when OutputType is set to <b>netflow</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.2</para>
        /// </summary>
        [NameInMap("NetflowServerIp")]
        [Validation(Required=false)]
        public string NetflowServerIp { get; set; }

        /// <summary>
        /// <para>The port of the NetFlow collector. Default value: <b>9995</b>. This parameter is required when OutputType is set to <b>netflow</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9995</para>
        /// </summary>
        [NameInMap("NetflowServerPort")]
        [Validation(Required=false)]
        public int? NetflowServerPort { get; set; }

        /// <summary>
        /// <para>The NetFlow version. Valid values: <b>V5</b>, <b>V9</b>, and <b>V10</b>. Default value: <b>V9</b>. This parameter is required when OutputType is set to <b>netflow</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V9</para>
        /// </summary>
        [NameInMap("NetflowVersion")]
        [Validation(Required=false)]
        public string NetflowVersion { get; set; }

        /// <summary>
        /// <para>The location where the flow log is stored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sls</b>: The flow log is stored in Log Service.</description></item>
        /// <item><description><b>netflow</b>: The flow log is stored on a NetFlow collector.</description></item>
        /// <item><description><b>all</b>: The flow log is stored both in Log Service and on a NetFlow collector.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The project to which the Logstore of Log Service belongs. This parameter is required when OutputType is set to <b>sls</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddrrgt</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the flow log is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where Log Service is deployed. This parameter is required when OutputType is set to <b>sls</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

    }

}
