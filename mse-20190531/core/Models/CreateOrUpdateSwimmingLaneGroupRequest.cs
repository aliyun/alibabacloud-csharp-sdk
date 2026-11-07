// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The IDs of the applications. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxn1po62@492b8f98d4bxxxx,xxxxn1po62@2d8f5d1b7f2xxxx</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>The end-to-end canary release mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Route by request content.</description></item>
        /// <item><description>1: Route by proportion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CanaryModel")]
        [Validation(Required=false)]
        public int? CanaryModel { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to enable canary release for databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DbGrayEnable")]
        [Validation(Required=false)]
        public bool? DbGrayEnable { get; set; }

        /// <summary>
        /// <para>The entry application. Format: Source system:ID. Examples:</para>
        /// <list type="bullet">
        /// <item><description>mse:${MSE application ID}</description></item>
        /// <item><description>mse-gw:${MSE cloud-native gateway ID}</description></item>
        /// <item><description>apig:${cloud-native API gateway ID}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse-gw:gw-2b1407e050f1446xxxcd2a65fd9xxxx</para>
        /// </summary>
        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        /// <summary>
        /// <para>The ID of the swimlane group. A value of -1 indicates that a swimlane group is created. A value greater than 0 indicates that a specified swimlane group is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The side where message queue canary release filtering is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("MessageQueueFilterSide")]
        [Validation(Required=false)]
        public string MessageQueueFilterSide { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable canary release for message queues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MessageQueueGrayEnable")]
        [Validation(Required=false)]
        public bool? MessageQueueGrayEnable { get; set; }

        /// <summary>
        /// <para>The name of the swimlane group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the MSE namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The paths. This parameter is required when a Java gateway is used as the entry point.</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>Specifies whether to record request details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecordCanaryDetail")]
        [Validation(Required=false)]
        public bool? RecordCanaryDetail { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The IDs of the routes. If a cloud-native gateway is used as the entry point, you must call this operation to pass the IDs of the selected cloud-native gateway routes before creating a swimlane for the swimlane group.</para>
        /// </summary>
        [NameInMap("RouteIds")]
        [Validation(Required=false)]
        public List<long?> RouteIds { get; set; }

        /// <summary>
        /// <para>The status of the swimlane group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Inactive.</description></item>
        /// <item><description>1: Active.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The version of the end-to-end canary release. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not recommended. Routes must be specified.</description></item>
        /// <item><description>2: Recommended. Routes do not need to be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SwimVersion")]
        [Validation(Required=false)]
        public int? SwimVersion { get; set; }

    }

}
