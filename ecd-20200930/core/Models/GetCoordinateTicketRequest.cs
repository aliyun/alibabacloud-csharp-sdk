// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetCoordinateTicketRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the stream collaboration. You can obtain the value of this parameter based on the value of <c>Coid</c> that is returned by the <c>ApplyCoordinationForMonitoring</c> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>co-0sot77uale3****</para>
        /// </summary>
        [NameInMap("CoId")]
        [Validation(Required=false)]
        public string CoId { get; set; }

        /// <summary>
        /// <para>The name of the convenience user account. If you initiate the request as an administrator, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/436773.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer connection task. The first time you initiate the request, you do not need to specify the ID of the cloud computer connection task. If no ticket is returned after you initiate the first request, you must specify the value of taskId that is returned for the first request in the subsequent request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39cc15e5-6998-4b9f-9b2c-7a4cc3e2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the user.</para>
        /// <para>Set the value to TENANT_ADMIN.</para>
        /// <list type="bullet">
        /// <item><description><para>The value of</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>TENANT_ADMIN</para>
        /// <!-- -->
        /// 
        /// <para>specifies an administrator.</para>
        /// </description></item>
        /// </list>
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
