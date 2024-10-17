// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of queries that can be performed each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxExecuteCount")]
        [Validation(Required=false)]
        public long? MaxExecuteCount { get; set; }

        /// <summary>
        /// <para>The maximum number of rows that can be queried each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResultCount")]
        [Validation(Required=false)]
        public long? MaxResultCount { get; set; }

        /// <summary>
        /// <para>The DingTalk ID or mobile number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>188xxxxxxxx</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The roles that the user assumes. For more information about the valid values, see the Request parameters section in the <a href="https://help.aliyun.com/document_detail/465812.html">UpdateUser</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADMIN,DBA</para>
        /// </summary>
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public string RoleNames { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>: To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud unique ID (UID) of the user to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
