// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ApproveOtaTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the delivery group resides. You can call the <a href="https://help.aliyun.com/document_detail/428500.html">ListRegions</a> operation to query the list of regions supported by App Streaming.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The type of the OTA update task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Fota: update of the system components of Alibaba Cloud Workspace</description></item>
        /// <item><description>AppUpdate</description></item>
        /// <item><description>ImageUpdate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fota</para>
        /// </summary>
        [NameInMap("OtaType")]
        [Validation(Required=false)]
        public string OtaType { get; set; }

        /// <summary>
        /// <para>The start time of the OTA update task. The time follows the ISO 8601 standard.</para>
        /// <para>This parameter is required.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-04T14:36:00+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the OTA update task. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <remarks>
        /// <para> Each successful call to the <c>ApproveOtaTask</c> operation causes a value change of this parameter.<c> Before you call this operation, call the `ListAppInstanceGroup` operation again to obtain the latest value of this parameter.</c></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ota-be7jzm29wrrz5****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
