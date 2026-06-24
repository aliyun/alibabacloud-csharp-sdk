// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ApproveOtaTaskRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the delivery group. You can call <a href="~~ListRegions~~">ListRegions</a> to query the list of regions supported by Wuying Cloud Application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The over-the-air upgrade task type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fota</para>
        /// </summary>
        [NameInMap("OtaType")]
        [Validation(Required=false)]
        public string OtaType { get; set; }

        /// <summary>
        /// <para>The start time of the over-the-air upgrade task. Specify the time in ISO 8601 format.</para>
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
        /// <para>The over-the-air upgrade task ID. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the ID.</para>
        /// <remarks>
        /// <para>Each successful call of <c>ApproveOtaTask</c> causes the <c>TaskId</c> to change. Therefore, before calling this operation again, call <c>ListAppInstanceGroup</c> again to obtain the latest <c>TaskId</c>.</para>
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
