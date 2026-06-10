// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinatePrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application for the coordinate permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>co-fqsm6e8ee75w6****</para>
        /// </summary>
        [NameInMap("CoId")]
        [Validation(Required=false)]
        public string CoId { get; set; }

        /// <summary>
        /// <para>The ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of user who requires the coordinate permissions.</para>
        /// <para>Valid value: TENANT_ADMIN.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT_ADMIN</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client. If you use an Alibaba Cloud Workspace client, click <b>About</b> on the client logon page to view the identifier of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E14A18BD4D088504B9F8A8751AB****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
