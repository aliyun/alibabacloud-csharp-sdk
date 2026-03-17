// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateFlowLogRequest : TeaModel {
        /// <summary>
        /// <para>The output interval under active connections. Valid values: <b>60 to 6000</b>. Unit: seconds. Default value: <b>300</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ActiveAging")]
        [Validation(Required=false)]
        public int? ActiveAging { get; set; }

        /// <summary>
        /// <para>The description of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The output interval under inactive connections. Valid values: <b>10 to 600</b>. Unit: seconds. Default value: <b>15</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("InactiveAging")]
        [Validation(Required=false)]
        public int? InactiveAging { get; set; }

        /// <summary>
        /// <para>The Logstore in Log Service.</para>
        /// <para>If OutputType is set to <b>sls</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>config-operation-log</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-flowlog-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IP address of the NetFlow collector where the flow log is stored.</para>
        /// <para>If OutputType is set to <b>netflow</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.2</para>
        /// </summary>
        [NameInMap("NetflowServerIp")]
        [Validation(Required=false)]
        public string NetflowServerIp { get; set; }

        /// <summary>
        /// <para>The port number of the NetFlow collector where the flow log is stored. Default value: <b>9995</b>.</para>
        /// <para>If OutputType is set to <b>netflow</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9995</para>
        /// </summary>
        [NameInMap("NetflowServerPort")]
        [Validation(Required=false)]
        public int? NetflowServerPort { get; set; }

        /// <summary>
        /// <para>The version of the NetFlow collector where the flow log is stored. Valid values: <b>V5</b>, <b>V9</b>, and <b>V10</b>. Default value: <b>V9</b>.</para>
        /// <para>If OutputType is set to <b>netflow</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V9</para>
        /// </summary>
        [NameInMap("NetflowVersion")]
        [Validation(Required=false)]
        public string NetflowVersion { get; set; }

        /// <summary>
        /// <para>The type of the flow log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sls</b>: The flow log is stored in Log Service.</description></item>
        /// <item><description><b>netflow</b>: The flow log is stored on a NetFlow collector.</description></item>
        /// <item><description><b>all</b>: The flow log is stored both in Log Service and on a NetFlow collector.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
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
        /// <para>The project in Log Service.</para>
        /// <para>If OutputType is set to <b>sls</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-flowlog-shanghai</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the flow log belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the region where Log Service is deployed.</para>
        /// <para>If OutputType is set to <b>sls</b> or <b>all</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

    }

}
