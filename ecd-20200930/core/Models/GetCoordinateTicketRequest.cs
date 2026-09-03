// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetCoordinateTicketRequest : TeaModel {
        /// <summary>
        /// <para>The coordination flow ID. This value is the <c>Coid</c> returned by the <a href="~~ApplyCoordinationForMonitoring~~">ApplyCoordinationForMonitoring</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>co-0sot77uale3****</para>
        /// </summary>
        [NameInMap("CoId")]
        [Validation(Required=false)]
        public string CoId { get; set; }

        /// <summary>
        /// <para>The username of the end user. This parameter is not required on the administrator side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The cloud computer connection task ID. This parameter is not required for the first request. If the first request does not return a Ticket, specify the <c>TaskId</c> returned by the first request in subsequent requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39cc15e5-6998-4b9f-9b2c-7a4cc3e2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT_ADMIN</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
